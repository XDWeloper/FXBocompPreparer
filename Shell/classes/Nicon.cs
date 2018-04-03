using FXBocompPreparer.classes;
using System;
using System.Windows;
using System.Windows.Forms;

namespace FXBicompPreparer.classes
{
    
    public  class Nicon
    {
        public static System.Windows.Forms.NotifyIcon Icon = new System.Windows.Forms.NotifyIcon();
        private static Nicon instance = new Nicon();

        public Nicon()
        {
            Icon.Icon = new System.Drawing.Icon("..\\..\\Shell\\favicon.ico");
            CreateMenu();
            Icon.DoubleClick += Icon_DoubleClick;
        }

        public static Nicon Instanse
        {
            get
            {
                return instance;
            }
        }


        public void Show()
        {
            Icon.Visible = true;
        }

        public void Hide()
        {
            Icon.Visible = false;
        }

        private void Icon_DoubleClick(object sender, EventArgs e)
        {
            Window _maiWin = WinController.Instance.GetWin("MainWindow");
            if (_maiWin == null) return;
            if (_maiWin.Visibility == Visibility.Visible)
                _maiWin.Visibility = Visibility.Hidden;
            else
                _maiWin.Visibility = Visibility.Visible;
        }

        private void CreateMenu() {
            ContextMenu _contMenu = new ContextMenu();
            MenuItem _menuItem1 = new MenuItem();
            _menuItem1.Index = 0;
            _menuItem1.Text = "Выход";
            _menuItem1.Click += new System.EventHandler(ClickExit);
            _contMenu.MenuItems.AddRange(new MenuItem[] { _menuItem1 });
            Icon.ContextMenu = _contMenu;
        }

        private void ClickExit(object sender, EventArgs e)
        {
            Icon.Visible = false;
            WinController.Instance.GetWin("MainWindow").Close();

        }
    }
}
