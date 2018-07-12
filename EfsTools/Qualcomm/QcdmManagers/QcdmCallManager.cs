using System;
using EfsTools.Qualcomm.QcdmCommands.Requests.CallManager;
using EfsTools.Qualcomm.QcdmCommands.Requests.Gsm;
using EfsTools.Qualcomm.QcdmCommands.Responses.CallManager;
using EfsTools.Qualcomm.QcdmCommands.Responses.Gsm;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmCallManager
    {
        public QcdmCallManager(QcdmManager manager)
        {
            _manager = new WeakReference<QcdmManager>(manager);
        }

        public UInt16 CallState
        {
            get
            {
                if (_manager.TryGetTarget(out QcdmManager manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new CallManagerStateInfoCommandRequest();
                        var response = (CallManagerStateInfoCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.CallState;
                    }
                }

                return 0;
            }
        }

        private readonly WeakReference<QcdmManager> _manager;
    }
}