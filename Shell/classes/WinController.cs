using System;
using System.Collections.Generic;
using System.Windows;

namespace FXBocompPreparer.classes
{
    class WinController
    {
        Dictionary<String, Window> _winCollection = new Dictionary<string, Window>();
        private static WinController _instance;

        public static WinController Instance
        {
            get
            {
                return _instance ?? (_instance = new WinController());
            }
        }

        public void SetWin(String _winName,Window _newWin)
        {
            _winCollection.Add(_winName,_newWin);
        }

        public Window GetWin(String _winName)
        {
            try{
                return _winCollection[_winName];
            }catch {
                return null;
            }
        }
    }
}
