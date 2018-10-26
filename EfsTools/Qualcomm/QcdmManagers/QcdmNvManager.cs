using System;
using System.Text;
using EfsTools.Qualcomm.QcdmCommands.Requests;
using EfsTools.Qualcomm.QcdmCommands.Requests.Gsm;
using EfsTools.Qualcomm.QcdmCommands.Requests.Nv;
using EfsTools.Qualcomm.QcdmCommands.Responses;
using EfsTools.Qualcomm.QcdmCommands.Responses.Gsm;
using EfsTools.Qualcomm.QcdmCommands.Responses.Nv;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmNvManager
    {
        public QcdmNvManager(QcdmManager manager)
        {
            _manager = new WeakReference<QcdmManager>(manager);
        }

        public byte[] Read(ushort itemId)
        {
            if (_manager.TryGetTarget(out QcdmManager manager))
            {
                if (manager.IsOpen)
                {
                    var request = new NvReadCommandRequest(itemId);
                    var response = (NvReadCommandResponse)manager.ExecuteQcdmCommandRequest(request);
                    return response.Data;
                }
            }
            return new byte[0];
        }

        public void Write(ushort itemId, byte[] data)
        {
            if (_manager.TryGetTarget(out QcdmManager manager))
            {
                if (manager.IsOpen)
                {
                    var request = new NvWriteCommandRequest(itemId, data);
                    var response = (NvWriteCommandResponse)manager.ExecuteQcdmCommandRequest(request);
                }
            }
        }

        public string ReadString(ushort itemId)
        {
            var bytes = Read(itemId);
            return Encoding.ASCII.GetString(bytes);
        }

        private readonly WeakReference<QcdmManager> _manager;
    }
}