using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surveillance
{
    public partial class Form1 : Form
    {
        private string chemin;
        public Form1()
        {
            InitializeComponent();
            treeView1.AfterSelect += treeView1_AfterSelect;

            comboBox1.SelectedIndex = 0;

            listView1.View = View.Details;
            listView1.Columns.Add("Date/Heure", 150);
            listView1.Columns.Add("Événement", 400);
        }


        private void AjouterLog(string message)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ListViewItem item = new ListViewItem(date);
            item.SubItems.Add(message);
            listView1.Items.Add(item);

            listView1.EnsureVisible(listView1.Items.Count - 1);
        }

        private void chargerBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                chemin = folderBrowserDialog.SelectedPath;
                txt.Text = chemin;

                treeView1.Nodes.Clear();
                TreeNode rootNode = new TreeNode(chemin);
                rootNode.Tag = chemin;
                treeView1.Nodes.Add(rootNode);

                ChargerDossier(chemin, rootNode);
                rootNode.Expand();

                fileSystemWatcher1.Path = chemin;
                fileSystemWatcher1.IncludeSubdirectories = true;
                fileSystemWatcher1.EnableRaisingEvents = true;
            }

        }

        private void ChargerDossierFiltrer(string chemin, TreeNode parentNode, string filtre)
        {
            try
            {
                foreach (string dossier in Directory.GetDirectories(chemin))
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dossier));
                    node.Tag = dossier;
                    parentNode.Nodes.Add(node);

                    ChargerDossierFiltrer(dossier, node, filtre);
                }

                foreach (string fichier in Directory.GetFiles(chemin))
                {
                    string ext = Path.GetExtension(fichier).ToLower();
                    if (filtre == "Tous" || ext == filtre)
                    {
                        TreeNode node = new TreeNode(Path.GetFileName(fichier));
                        node.Tag = fichier;
                        parentNode.Nodes.Add(node);
                    }
                }
            }
            catch {}
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chemin = e.Node.Tag != null ? e.Node.Tag.ToString() : e.Node.Text;
            folderControll1.FolderName = e.Node.Text;
            folderControll1.FolderChemin = chemin;
            folderControll1.DateCreation = File.GetCreationTime(chemin).ToString();
            folderControll1.DateCreation = Directory.GetCreationTime(chemin).ToString();

            if (Directory.Exists(chemin))
            {
                folderControll1.FolderIcon = Properties.Resources.dossier;
            }
            else if (File.Exists(chemin))
            {
                string extension = Path.GetExtension(chemin).ToLower();

                switch (extension)
                {
                    case ".txt":
                        folderControll1.FolderIcon = Properties.Resources.document;
                        break;
                    case ".pdf":
                        folderControll1.FolderIcon = Properties.Resources.fichier_pdf;
                        break;
                    case ".jpg":
                    case ".png":
                        folderControll1.FolderIcon = Properties.Resources.image;
                        break;
                    case ".mp4":
                        folderControll1.FolderIcon = Properties.Resources.film;
                        break;
                    case ".mp3":
                        folderControll1.FolderIcon = Properties.Resources.musique_alt__1_;
                        break;
                    case ".rar":
                        folderControll1.FolderIcon = Properties.Resources.fichier_zip;
                        break;
                    default:
                        folderControll1.FolderIcon = Properties.Resources.document;
                        break;
                }
            }

            if (File.Exists(chemin))
            {
                // Taille du fichier en octets
                FileInfo fi = new FileInfo(chemin);
                folderControll1.Taille = ($"{fi.Length.ToString()} ko");
            }
            else
            {
                // Dossier :
                folderControll1.Taille = "0";
            }
        }

        private void ChargerDossier(string chemin, TreeNode parentNode)
        {
            try
            {
                // Ajouter les sous-dossiers
                string[] dossiers = Directory.GetDirectories(chemin);
                foreach (string dossier in dossiers)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dossier));
                    node.Tag = dossier;
                    parentNode.Nodes.Add(node);

                    ChargerDossier(dossier, node);
                }

                // Ajouter les fichiers
                string[] fichiers = Directory.GetFiles(chemin);
                foreach (string fichier in fichiers)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(fichier));
                    node.Tag = fichier;
                    parentNode.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

            AjouterLog($"Fichier modifié : {e.Name}");
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            AjouterLog($"Fichier créé : {e.Name}");
        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            AjouterLog($"Fichier supprimé : {e.Name}");
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            AjouterLog($"Fichier renommé : {e.OldName} → {e.Name}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chemin)) return;
            treeView1.Nodes.Clear();
            string filtre = comboBox1.SelectedItem.ToString();

            TreeNode root = new TreeNode(Path.GetFileName(chemin)) { Tag = chemin };
            treeView1.Nodes.Add(root);

            ChargerDossierFiltrer(chemin, root, filtre);
            root.Expand();
        }
    }
}
