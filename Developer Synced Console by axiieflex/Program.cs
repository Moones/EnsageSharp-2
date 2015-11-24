using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Text;
using Ensage;

namespace axiieflex.ensage2.DeveloperSyncedConsole
{
    class Program
    {

        #region Native API import

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

        enum ShowWindowCommands { SW_HIDE = 0x0, SW_SHOW = 0x5 }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        #endregion

        #region Core
        /// <summary>
        /// Прячет окно по идентификатору
        /// </summary>
        /// <param name="hwnd">Идентификато окна</param>
        /// <returns></returns>
        static bool HideWindow(IntPtr hwnd)
        {
            if (IsWindow(hwnd)) // обязательно проверяем существует ли еще окно перед вызовом
            {
                if (IsWindowVisible(hwnd))
                {
                    ShowWindow(hwnd, ShowWindowCommands.SW_HIDE);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Показывает окно по идентификатору
        /// </summary>
        /// <param name="hwnd">Идентификатор окна</param>
        /// <returns></returns>
        static bool ShowWindow(IntPtr hwnd)
        {
            if (IsWindow(hwnd)) // обязательно проверяем существует ли еще окно перед вызовом
            {
                if (!IsWindowVisible(hwnd))
                {
                    ShowWindow(hwnd, ShowWindowCommands.SW_SHOW);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Инвертирует видимость окна по идентификатору
        /// </summary>
        /// <param name="hwnd">Идентификатор окна</param>
        /// <returns></returns>
        static bool InvertWindow(IntPtr hwnd)
        {
            if (IsWindowVisible(hwnd))
            {
                return HideWindow(hwnd);
            }
            else
            {
                return ShowWindow(hwnd);
            }
        }

        static bool InvertConsoleWindow()
        {
            if (Dota2_Console == null) return false;
            return InvertWindow(Dota2_Console.Handle);
        }

        #endregion

        #region global variable

        static WindowInformation Dota2_Main = new WindowInformation();

        static WindowInformation Dota2_Console = new WindowInformation();

        #endregion

        static void Main(string[] args)
        {

            
            try {

                List<WindowInformation> w = WindowList.GetAllWindowsExtendedInfo();

                // главное окно доты
                Dota2_Main = w.Find(x => x.Class.Contains("SDL_app") &&                            // класс главного окна доты
                                         x.Caption.Contains("Dota 2") &&                           // и правильное имя окна :3
                                         x.Process.MainModule.FileName.Contains("dota2.exe") &&    // процесс dota2
                                         x.Process.MainModule.FileName.Contains("win64"));         // только для 64 битной доты

                // консольное окно доты (открываемое Ensage)
                Dota2_Console = w.Find(x => x.Class.Contains("Console") &&                         // класс окна хоста консоли
                                            x.Caption.Contains("AppData") &&                       // содержит информацию о путе в профиле пользователя
                                            x.Caption.StartsWith("file://") &&                     // содержит отсылку о стартовом путе
                                            x.Process.MainModule.FileName.Contains("dota2.exe") && // процесс dota2
                                            x.Process.MainModule.FileName.Contains("win64"));      // только для 64 битной доты



            }
            catch (Exception)
            {
                // если вдруг будут ошибки, хотя я не смог такого добиться
                // то мы просто выходим из функции и все
                return;
            }
                     
            
            // если не нашли окно с игрой, а такой бывает ОЧЕНЬ редко - то выходим
            if (Dota2_Main == null) return;
            // если не нашли окно с консолью, такого вообще не бывает, однако...
            if (Dota2_Console == null) return;

            // по дефолту прячем консоль
            HideWindow(Dota2_Console.Handle);
            
            Ensage.Game.OnWndProc += Game_OnWndProc;

            return;
        }

        private static void Game_OnWndProc(WndEventArgs args)
        {

            var _args = args;

            const uint WM_CHAR = 0x102;

            // если что-то пишем что игнорим
            if (Ensage.Game.IsChatOpen)
                return;


            // да да, я хз почему, но работает только WM_CHAR, WM_KEYDOWN+WM_KEYUP не робит, ну и нахуй :D
            // TODO: добавить чтения биндов из config.cfg
            if ((_args.Msg == WM_CHAR) && (_args.WParam == '\\'))
            {
                InvertConsoleWindow();
            }

        }


    }
}
