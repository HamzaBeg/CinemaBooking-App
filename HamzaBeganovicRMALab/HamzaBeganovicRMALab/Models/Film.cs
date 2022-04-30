using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace HamzaBeganovicRMALab.Models
{
    public class Film
    {
        
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        private string ocjena;

        public string Ocjena
        {
            get { return ocjena; }
            set { ocjena = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        private string opis { get; set; }

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
    }
}
