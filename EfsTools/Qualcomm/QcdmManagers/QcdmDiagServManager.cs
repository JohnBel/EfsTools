using System;
using EfsTools.Qualcomm.QcdmCommands.Requests.DiagServ;
using EfsTools.Qualcomm.QcdmCommands.Responses.DiagServ;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmDiagServManager
    {
        private readonly WeakReference<QcdmManager> _manager;

        public QcdmDiagServManager(QcdmManager manager)
        {
            _manager = new WeakReference<QcdmManager>(manager);
        }

        public int DebugMessageDroppedCount
        {
            get
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new GetDebugMessageDroppedCountRequest();
                        var response = (GetDebugMessageDroppedCountResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Value;
                    }
                }

                return 0;
            }
        }

        public int DebugMessageAllocationCount
        {
            get
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new GetDebugMessageAllocationCountRequest();
                        var response =
                            (GetDebugMessageAllocationCountResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Value;
                    }
                }

                return 0;
            }
        }

        public int EventDroppedCount
        {
            get
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new GetEventDroppedCountRequest();
                        var response = (GetEventDroppedCountResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Value;
                    }
                }

                return 0;
            }
        }

        public int EventAllocationCount
        {
            get
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new GetEventAllocationCountRequest();
                        var response = (GetEventAllocationCountResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Value;
                    }
                }

                return 0;
            }
        }

        public int LogDroppedCount
        {
            get
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new GetLogDroppedCountRequest();
                        var response = (GetLogDroppedCountResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Value;
                    }
                }

                return 0;
            }
        }

        public int LogAllocationCount
        {
            get
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new GetLogAllocationCountRequest();
                        var response = (GetLogAllocationCountResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Value;
                    }
                }

                return 0;
            }
        }
    }
}