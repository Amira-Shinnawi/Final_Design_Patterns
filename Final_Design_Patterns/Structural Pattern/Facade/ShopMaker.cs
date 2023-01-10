using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Design_Patterns.Structural_Pattern.Facade
{
    class ShopMaker
    {
        private IMobileShop nokia;
        private IMobileShop iphone;
        private IMobileShop samsung;

        public ShopMaker()
        {
            iphone = new IPhone();
            samsung = new Samsung();
            nokia = new Nokia();
        }
        public void iphonePhoneSale()
        {
            iphone.getMobileModelNumber();
            iphone.getMobilePrice();
        }

        public void samsungPhoneSale()
        {
            samsung.getMobileModelNumber();
            samsung.getMobilePrice();
        }
        public void nokiaPhoneSale()
        {
            nokia.getMobileModelNumber();
            nokia.getMobilePrice();
        }

    }
}
