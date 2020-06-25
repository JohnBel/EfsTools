using System;
using EfsTools.Qualcomm.QcdmCommands.Requests.CallManager;
using EfsTools.Qualcomm.QcdmCommands.Responses.CallManager;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmCallManager
    {
        private readonly WeakReference<QcdmManager> _manager;

        public QcdmCallManager(QcdmManager manager)
        {
            _manager = new WeakReference<QcdmManager>(manager);
        }

        public ushort CallState
        {
            get
            {
                if (_manager.TryGetTarget(out var manager))
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
    }
}