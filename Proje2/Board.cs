using System;
using System.Collections.Generic;
namespace Proje_2
{
    public class Board : IBoard
    {
        private int _sayi;
        IKartDal _kartDal;
        public Board()
        {
            ToDo toDo = new ToDo();
            InProgress ınProgress = new InProgress();
            Done done = new Done();
            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n**********************************\n\n(1) Board Listelemek\n\n(2) Board'a kart eklemek\n\n(3) Board'dan kart silmek\n\n(4) Kart Taşımak");
            _sayi = Convert.ToInt32(Console.ReadLine());
            if (_sayi == 1)
            {
                Listele();
            }
            else if (_sayi == 2)
            {
                Ekle();
            }
            else if (_sayi == 3)
            {
                Sil();
            }
            else if (_sayi == 4)
            {
                Tasi();
            }

        }
        public Board(IKartDal kartDal)
        {
            _kartDal = kartDal;
        }
        public void Ekle()
        {
            
            ToDo toDo=new ToDo();
            toDo.Ekle(new Kart());
        }

        public void Listele()
        {

            _kartDal = new ToDo();
            _kartDal = new InProgress();
            _kartDal = new Done();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }

        public void Tasi()
        {
            throw new NotImplementedException();
        }
    }
}