using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surveillance
{
    public partial class folderControll : UserControl
    {
        public folderControll()
        {
            InitializeComponent();
        }

        public string _folderName;
        public string FolderName
        {
            get { return _folderName; }
            set
            {
                _folderName = value;
                nameTxt.Text = value;
            }
        }


        public Image _folderIcon;
        public Image FolderIcon
        {
            get { return _folderIcon; }
            set
            {
                _folderIcon = value;
                icon.Image = _folderIcon;
            }
        }

        public string _folderChemin;
        public string FolderChemin
        {
            get { return _folderChemin; }
            set
            {
                _folderChemin = value;
                pathTxt.Text = value;
            }
        }

        public string _dateCreation;
        public string DateCreation
        {
            get { return _dateCreation; }
            set
            {
                _dateCreation = value;
                dateTxt.Text = value;
            }
        }


        public string _taille;
        public string Taille
        {
            get { return _taille; }
            set
            {
                _taille = value;
                tailleTxt.Text = value;
            }
        }
    }
}
