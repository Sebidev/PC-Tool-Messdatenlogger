/*
[PC-Tool Messdatenlogger]

Copyright (C) [2017]  [Sebastian B�rger]

Dieses Programm ist freie Software. Sie k�nnen es unter den Bedingungen der GNU General Public License, wie von der Free Software Foundation ver�ffentlicht, weitergeben und/oder modifizieren, entweder gem�� Version 3 der Lizenz oder (nach Ihrer Option) jeder sp�teren Version.

Die Ver�ffentlichung dieses Programms erfolgt in der Hoffnung, da� es Ihnen von Nutzen sein wird, aber OHNE IRGENDEINE GARANTIE, sogar ohne die implizite Garantie der MARKTREIFE oder der VERWENDBARKEIT F�R EINEN BESTIMMTEN ZWECK. Details finden Sie in der GNU General Public License.

Sie sollten ein Exemplar der GNU General Public License zusammen mit diesem Programm erhalten haben. Falls nicht, siehe <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RS232
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fclsRS232Tester());
        }
    }
}