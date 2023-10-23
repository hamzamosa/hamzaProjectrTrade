using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexFXClient.images
{
    public class IconViewModel
    {
        public string NewPostion 
        {
            get { return GetPath("NewPostion.png"); }
        
        }
        public string AarabicLang
        {
            get { return GetPath("Arabic.png"); }

        }
        public string EnglishLang
        {
            get { return GetPath("united-states (1).png"); }

        }
        public string HindiLang
        {
            get { return GetPath("india.png"); }

        }
        public string ebrilang
        {
            get { return GetPath("honduras.png"); }

        }
        public string FrenchLang
        {
            get { return GetPath("france.png"); }

        }
        public string chineseLang
        {
            get { return GetPath("china.png"); }

        }
        public string spanichLang
        {
            get { return GetPath("spain.png"); }

        }
        public string japanesLang
        {
            get { return GetPath("japan.png"); }

        }
        public string portugalLang
        {
            get { return GetPath("portugal.png"); }

        }
        public string russianLang
        {
            get { return GetPath("russia.png"); }

        }
        public string urduLang
        {
            get { return GetPath("pakistan.png"); }

        }

        public string ellipse
        {
            get { return GetPath("icons8-ellipse-48.png"); }

        }
        public string traiangle
        {
            get { return GetPath("icons8-triangle-32.png"); }

        }
        public string rectangle
        {
            get { return GetPath("icons8-rectangle-48.png"); }

        }

        public string random
        {
            get { return GetPath("Sybmbols.png"); }

        }

        public string GetPath(string iconString)
        {
            return "/VertexFXClient;Component/images/" + iconString;
        }
    }
}
