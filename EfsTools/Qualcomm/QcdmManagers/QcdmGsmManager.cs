using System;
using EfsTools.Qualcomm.QcdmCommands.Requests.Gsm;
using EfsTools.Qualcomm.QcdmCommands.Responses.Gsm;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmGsmManager
    {
        public QcdmGsmManager(QcdmManager manager)
        {
            _manager = new WeakReference<QcdmManager>(manager);
        }

        //GsmVersion
        public GsmVersion Version
        {
            get
            {
                if (_manager.TryGetTarget(out QcdmManager manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new GsmVersionCommandRequest();
                        var response = (GsmVersionCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Version;
                    }
                }

                return null;
            }
        }

        private readonly WeakReference<QcdmManager> _manager;
    }
}