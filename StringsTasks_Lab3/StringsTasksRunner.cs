using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;

namespace StringsTasks_Lab3
{
    public class StringsTasksRunner : IRunner
    {
        public Iinterface UserInterface { get; set; }

        public StringsTasksRunner(Iinterface ui)
        {
            UserInterface = ui;
        }

        public void Run()
        {
            string fullname;
            
            UserInterface.Write("\nZavd 1 --------------\n");

            UserInterface.Write("Input your fullname in format {Surname} {Name} {Patronymic}\n");

            try
            {
                fullname = UserInterface.Read();
                StringManipulator tsk1 = new StringManipulator(fullname);
                string name = tsk1.Str.Split()[1];
                string encName = StringEncryptor.Encrypt(fullname);

                UserInterface.Write($"Довжина: {tsk1.Length}\n кiлькiсть букв спiвпадаючих iз другою буквою прiзвища: {tsk1.CountOfLikeSecndLetterOfFrstWord()}\n");

                tsk1.InsertMinusBetweenLetters();
                tsk1.ReplaceVowelsToUpper();

                UserInterface.Write(tsk1.Str + "\nКоментар:\nВиконав Малевич Максим Сергiйович\nСпецiальнiсть: IТП. Група: \n");
                UserInterface.Write("Iм'я: " + name  + $"\nKiлькiсть букв у третiм словi: {tsk1.ThirdWordCount()}\n");

                
                UserInterface.Write("Зашифроване методом здвигу вправо на ПIБ: "+ encName+"\n");
                UserInterface.Write("Розшифроване ПIБ: " + StringEncryptor.Decrypt(encName)+"\n");
            }
            catch
            { throw new Exception("очепятка"); }
        }
    }
}
