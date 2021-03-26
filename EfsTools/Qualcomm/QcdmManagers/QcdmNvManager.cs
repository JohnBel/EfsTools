using System;
using System.Text;
using EfsTools.Items;
using EfsTools.Qualcomm.QcdmCommands.Requests.Nv;
using EfsTools.Qualcomm.QcdmCommands.Responses.Nv;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmNvManager
    {
        private readonly WeakReference<QcdmManager> _manager;

        public QcdmNvManager(QcdmManager manager)
        {
            _manager = new WeakReference<QcdmManager>(manager);
        }

        public byte[] Read(ushort itemId)
        {
            if (_manager.TryGetTarget(out var manager))
            {
                if (manager.IsOpen)
                {
                    var request = new NvReadCommandRequest(itemId);
                    var response = manager.ExecuteQcdmCommandRequest<NvReadCommandResponse>(request);
                    if (response != null)
                    {
                        var size = ItemsFactory.SizeOfNvItem(itemId);
                        if (size > 0)
                        {
                            size = Math.Min(response.Data.LongLength, size);
                            var data = new byte[size];
                            Array.Copy(response.Data, 0, data, 0, size);
                            return data;
                        }

                        return response.Data;
                    }
                }
            }

            return new byte[0];
        }

        public void Write(ushort itemId, byte[] data)
        {
            if (_manager.TryGetTarget(out var manager))
            {
                if (manager.IsOpen)
                {
                    var request = new NvWriteCommandRequest(itemId, data);
                    var response = manager.ExecuteQcdmCommandRequest<NvWriteCommandResponse>(request);
                }
            }
        }

        public string ReadString(ushort itemId)
        {
            var bytes = Read(itemId);
            return Encoding.ASCII.GetString(bytes);
        }
    }
}