using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XVM_EnableGoldFreeXPLocker
{
    public partial class main : Form
    {
        public string path = "";
        public string pathHangar = "";
        bool gold = false;
        bool xp = false;
        bool bon = false;
        public main()
        {
            InitializeComponent();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(path))
            {
                if (File.Exists(Path.Combine(path, @"res_mods\configs\xvm\xvm.xc")))
                {
                    textBoxPath.Text = path;
                    groupBox2.Enabled = true;
                    var res = File.ReadAllLines(Path.Combine(path, @"res_mods\configs\xvm\xvm.xc"));
                    Regex regex = new Regex("\"(.*)/@xvm.xc");
                    foreach (string line in res)
                    {
                        Match match = regex.Match(line);
                        if (match.Groups[1].Length > 0)
                        {
                            pathHangar = Path.Combine(path, @"res_mods\configs\xvm\" + match.Groups[1].Value + @"\hangar.xc");
                        }
                    }
                    setData();
                }
                else
                {
                    MessageBox.Show("В автоматически обнаруженной игре не установлен XVM или файл xvm.xc отсутствует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupBox2.Enabled = false;
                }
            }
        }

        private void setData()
        {
            if (!String.IsNullOrEmpty(pathHangar))
            {
                var res = File.ReadAllLines(pathHangar);
                Regex regexGold = new Regex("\"enableGoldLocker\": (.*),");
                Regex regexXp = new Regex("\"enableFreeXpLocker\": (.*),");
                Regex regexBon = new Regex("\"enableCrystalLocker\": (.*),");
                foreach (string line in res)
                {
                    Match match = regexGold.Match(line);
                    if (match.Groups[1].Length > 0)
                    {
                        if (match.Groups[1].Value == "false") gold = false; else gold = true;
                    }
                    match = regexXp.Match(line);
                    if (match.Groups[1].Length > 0)
                    {
                        if (match.Groups[1].Value == "false") xp = false; else xp = true;
                    }
                    match = regexBon.Match(line);
                    if (match.Groups[1].Length > 0)
                    {
                        if (match.Groups[1].Value == "false") bon = false; else bon = true;
                    }
                }

                if (bon)
                {
                    labelBonStatus.ForeColor = Color.Green;
                    labelBonStatus.Text = "Включен";
                }
                else
                {
                    labelBonStatus.ForeColor = Color.Red;
                    labelBonStatus.Text = "Выключен";
                }
                if (xp)
                {
                    labelXPStatus.ForeColor = Color.Green;
                    labelXPStatus.Text = "Включен";
                }
                else
                {
                    labelXPStatus.ForeColor = Color.Red;
                    labelXPStatus.Text = "Выключен";
                }
                if (gold)
                {
                    labelStatusGold.ForeColor = Color.Green;
                    labelStatusGold.Text = "Включен";
                }
                else
                {
                    labelStatusGold.ForeColor = Color.Red;
                    labelStatusGold.Text = "Выключен";
                }

                var icons_dir = @"res_mods\mods\shared_resources\xvm\res\locker";
                icons_dir = Path.Combine(path, icons_dir);
                bool error = false;
                if (Directory.Exists(icons_dir))
                {
                    if (!File.Exists(Path.Combine(icons_dir, "locked.png"))) error = true;
                    if (!File.Exists(Path.Combine(icons_dir, "unlocked.png"))) error = true;
                    if (error)
                    {
                        var response = MessageBox.Show("Файлы иконок замочков не обнаруженны. Без них не будет иконки замочка в ангаре (она будет невидима).\r\nДобавить их?",
                            "Файлы иконок не найдены",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                        if (response == DialogResult.OK)
                        {
                            ImageConverter converter = new ImageConverter();
                            File.WriteAllBytes(Path.Combine(icons_dir, "locked.png"), (byte[])converter.ConvertTo(Properties.Resources.locked, typeof(byte[])));
                            File.WriteAllBytes(Path.Combine(icons_dir, "unlocked.png"), (byte[])converter.ConvertTo(Properties.Resources.unlocked, typeof(byte[])));
                        }
                    }
                }
                else
                {
                    Directory.CreateDirectory(icons_dir);
                    var response = MessageBox.Show("Файлы иконок замочков не обнаруженны. Без них не будет иконки замочка в ангаре (она будет невидима).\r\nДобавить их?",
                           "Файлы иконок не найдены", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (response == DialogResult.OK)
                    {
                        ImageConverter converter = new ImageConverter();
                        File.WriteAllBytes(Path.Combine(icons_dir, "locked.png"), (byte[])converter.ConvertTo(Properties.Resources.locked, typeof(byte[])));
                        File.WriteAllBytes(Path.Combine(icons_dir, "unlocked.png"), (byte[])converter.ConvertTo(Properties.Resources.unlocked, typeof(byte[])));
                    }
                }
            }
        }

        private void save()
        {
            var res = File.ReadAllLines(pathHangar);
            Regex regexGold = new Regex("\"enableGoldLocker\": (.*),");
            Regex regexXp = new Regex("\"enableFreeXpLocker\": (.*),");
            Regex regexBon = new Regex("\"enableCrystalLocker\": (.*),");
            string[] lines = new string[res.Count()];
            var i = 0;
            foreach (string ln in res)
            {
                var line = ln;
                Match match = regexGold.Match(line);
                if (match.Groups[1].Length > 0)
                {
                    if (gold == true) { line = line.Replace("false", "true"); } else { line = line.Replace("true", "false"); }
                }
                match = regexXp.Match(line);
                if (match.Groups[1].Length > 0)
                {
                    if (xp == true) { line = line.Replace("false", "true"); } else { line = line.Replace("true", "false"); }
                }
                match = regexBon.Match(line);
                if (match.Groups[1].Length > 0)
                {
                    if (bon == true) { line = line.Replace("false", "true"); } else { line = line.Replace("true", "false"); }
                }
                lines[i] = line;
                i++;
            }
            File.WriteAllLines(pathHangar, lines);
        }

        private void LabelStatusGold_Click(object sender, EventArgs e)
        {
            gold = !gold;
            if (gold)
            {
                labelStatusGold.ForeColor = Color.Green;
                labelStatusGold.Text = "Включен";
            }
            else
            {
                labelStatusGold.ForeColor = Color.Red;
                labelStatusGold.Text = "Выключен";
            }
            save();
        }

        private void LabelXPStatus_Click(object sender, EventArgs e)
        {
            xp = !xp;
            if (xp)
            {
                labelXPStatus.ForeColor = Color.Green;
                labelXPStatus.Text = "Включен";
            }
            else
            {
                labelXPStatus.ForeColor = Color.Red;
                labelXPStatus.Text = "Выключен";
            }
            save();
        }

        private void LabelBonStatus_Click(object sender, EventArgs e)
        {
            bon = !bon;
            if (bon)
            {
                labelBonStatus.ForeColor = Color.Green;
                labelBonStatus.Text = "Включен";
            }
            else
            {
                labelBonStatus.ForeColor = Color.Red;
                labelBonStatus.Text = "Выключен";
            }
            save();
        }

        private void OpenDlgBtn_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                dialog.Description = "Выберите папку с игрой";
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;

                if (File.Exists(Path.Combine(dialog.SelectedPath, @"res_mods\configs\xvm\xvm.xc")))
                {
                    path = dialog.SelectedPath;
                    textBoxPath.Text = path;
                    groupBox2.Enabled = true;
                    var res = File.ReadAllLines(Path.Combine(path, @"res_mods\configs\xvm\xvm.xc"));
                    Regex regex = new Regex("\"(.*)/@xvm.xc");
                    foreach (string line in res)
                    {
                        Match match = regex.Match(line);
                        if (match.Groups[1].Length > 0)
                        {
                            pathHangar = Path.Combine(path, @"res_mods\configs\xvm\" + match.Groups[1].Value + @"\hangar.xc");
                        }
                    }
                    setData();
                }
                else
                {
                    MessageBox.Show("У вас не установлен XVM или файл xvm.xc отсутствует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
