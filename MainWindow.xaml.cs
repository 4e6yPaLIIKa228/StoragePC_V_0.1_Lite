using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StoragePC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Bt_Reg_Click(object sender, RoutedEventArgs e)
        {
            Regist Regist = new Regist();
            this.Close();
            Regist.Show();
        }

        private void BtLog_Click(object sender, RoutedEventArgs e)
        {

           
         
                // avtoris.Autorisation(TexBxFamil, TexBxSNULS, this);
                if (String.IsNullOrEmpty(PassBx.Password) || String.IsNullOrEmpty(Tx_Log.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            else
            {
                if (PassBx.Password.Length < 4) //Проверка,пароля на колл символов
                {
                    MessageBox.Show("Пароль должен быть больше 4 символов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    DateBase DateBase = new DateBase();
                    this.Close();
                    DateBase.Show();
                }
            }
            //{
            //    DateBase DateBase = new DateBase();
            //    this.Close();
            //    DateBase.Show();
            //}
                //else
                //{
                //    if (PassBx.Password.Length < 4) //Проверка,пароля на колл символов
                //    {
                //        MessageBox.Show("Пароль должен быть больше 4 символов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                //    }
                //    else
                //    {


                //        autoris emp = db.autoris.singleordefault(c => c.login == tx_log.text);
                //        if (emp == null)
                //        {
                //            messagebox.show("такого пользователя не существует");
                //            lbname.content = emp.name;
                //            return;
                //        }
                //        func f = new func();
                //        if (f.checkpassword(emp.pass, f.gethashpassword(passbx.password)))
                //        {
                //            lbname.content = emp.name;//интересно
                //            messagebox.show($"здравствуйте, {emp.first_name} {emp.name} {emp.otchestvo}");
                //            menu n4 = new menu();
                //            this.close();
                //            n4.show();
                //        }
                //        else
                //        {
                //            messagebox.show("пароль неверный!");
                //        }
                //    }
                //}
            }
        
    }
}
