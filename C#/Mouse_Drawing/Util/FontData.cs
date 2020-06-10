using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_hkj.Util
{
    [Serializable]
    class FontData
    {

        public String text { get; set; }
        public String font { get; set; }
        public float size { get; set; }
        public FontStyle style { get; set; }



        public FontData()
        {
            font = "MS UI Gothic";
            size = 10;
        }



        public FontData(String font, int size)
        {
            this.font = font;
            this.size = (float)size;
        }



        public Font getFont()
        {
            if(style == null)
            {
                return new Font(font, size);
            }
            else
            {
                return new Font(font, size, style);
            }


        }
    }
}
