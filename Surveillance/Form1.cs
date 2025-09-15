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
        public Form1()
        {
            InitializeComponent();
        }

        private void chargerBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string chemin = folderBrowserDialog.SelectedPath;
                txt.Text = chemin;

                treeView1.Nodes.Clear();
                TreeNode rootNode = new TreeNode(chemin);
                rootNode.Tag = chemin;
                treeView1.Nodes.Add(rootNode);

                ChargerDossier(chemin, rootNode);
                rootNode.Expand();

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
            MessageBox.Show($"Changed: {e.Name}");

        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            MessageBox.Show($"Created: {e.Name}");
        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            MessageBox.Show($"Deleted: {e.Name}");
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            MessageBox.Show($"Renamed: {e.OldName} --> {e.Name}");
        }
    }
}
