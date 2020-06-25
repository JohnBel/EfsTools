using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EfsTools.Qualcomm.QcdmCommands.Attributes;
using EfsTools.Resourses;

namespace EfsTools.Qualcomm.QcdmCommands
{
    using QcdmCommandResponseCreatorFun = Func<byte[], IQcdmCommandResponse>;

    internal static class QcdmCommandResponseFactory
    {
        private static readonly Dictionary<uint, QcdmCommandResponseCreatorFun> _commandResponseCreators =
            new Dictionary<uint, QcdmCommandResponseCreatorFun>();

        static QcdmCommandResponseFactory()
        {
            InitializeCommandResponseCreators();
            InitializeSubSystemResponseCreators();
        }

        public static Logger Logger { get; set; }

        public static IQcdmCommandResponse CommandResponse(QcdmCommand command, byte[] data)
        {
            IQcdmCommandResponse result = null;
            switch (command)
            {
                case QcdmCommand.SubsysCmd:
                    result = CreateSubsysCommandResponse(data);
                    break;
                default:
                    result = CreateCommandResponse(command, data);
                    break;
            }

            return result;
        }

        private static IQcdmCommandResponse CreateCommandResponse(QcdmCommand command, byte[] data)
        {
            var key = (uint) command;
            if (_commandResponseCreators.TryGetValue(key, out var creator))
            {
                return creator(data);
            }

            throw new QcdmManagerException(string.Format(Strings.QcdmUnsupportedCommandResponseFormat, command));
        }

        private static IQcdmCommandResponse CreateSubsysCommandResponse(byte[] data)
        {
            if (data != null && data.Length > 3)
            {
                var key = BitConverter.ToUInt32(data, 0);
                if (_commandResponseCreators.TryGetValue(key, out var creator))
                {
                    return creator(data);
                }

                throw new QcdmManagerException(string.Format(Strings.QcdmUnsupportedSubsysCommandResponseFormat,
                    data[1]));
            }

            throw new QcdmManagerException(string.Format(Strings.QcdmUnsupportedSubsysCommandResponseFormat, -1));
        }

        private static void InitializeCommandResponseCreators()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var modules = assembly.GetModules();
            var module = modules.FirstOrDefault();
            if (module != null)
            {
                foreach (var type in module.GetTypes())
                {
                    if (!type.IsAbstract && !type.IsEnum &&
                        type.GetCustomAttributes(typeof(QcdmCommandAttribute), true).FirstOrDefault() is
                            QcdmCommandAttribute attribute)
                    {
                        var command = attribute.Command;
                        if (command != QcdmCommand.SubsysCmd)
                        {
                            var methodInfo = type.GetMethod("Parse",
                                BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Static);
                            if (methodInfo != null)
                            {
                                var fun = new QcdmCommandResponseCreatorFun(data =>
                                {
                                    try
                                    {
                                        return (IQcdmCommandResponse) methodInfo.Invoke(null, new object[] { data });
                                    }
                                    catch (Exception e)
                                    {
                                        if (Logger != null)
                                        {
                                            Logger.LogError(e.Message);
                                        }
                                    }

                                    return null;
                                });
                                var key = (uint) command;
                                _commandResponseCreators[key] = fun;
                            }
                        }
                    }
                }
            }
        }

        private static void InitializeSubSystemResponseCreators()
        {
            var assembly = Assembly.GetExecutingAssembly();
            foreach (var type in assembly.GetTypes())
            {
                if (!type.IsAbstract && !type.IsEnum &&
                    type.GetCustomAttributes(typeof(QcdmSubSystemCommandAttribute), true).FirstOrDefault() is
                        QcdmSubSystemCommandAttribute attribute)
                {
                    var command = BitConverter.GetBytes(attribute.Command);
                    var subSystem = attribute.SubSystem;
                    var bytes = new[] { (byte) QcdmCommand.SubsysCmd, (byte) subSystem, command[0], command[1] };
                    var key = BitConverter.ToUInt32(bytes, 0);
                    var methodInfo = type.GetMethod("Parse",
                        BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Static);
                    if (methodInfo != null)
                    {
                        var fun = new QcdmCommandResponseCreatorFun(data =>
                        {
                            try
                            {
                                return (IQcdmCommandResponse) methodInfo.Invoke(null, new object[] { data });
                            }
                            catch (Exception e)
                            {
                                if (Logger != null)
                                {
                                    Logger.LogError(e.Message);
                                }
                            }

                            return null;
                        });
                        _commandResponseCreators[key] = fun;
                    }
                }
            }
        }
    }
}