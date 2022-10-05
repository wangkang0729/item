using System.Xml;

namespace item
{
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
        }

        private void items_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string appPath = Environment.CurrentDirectory;
            string path = appPath+"../../../../itemsXml/item0001.xml";
            writeItemsXml(path);
        }

        private bool writeItemsXml(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                XmlElement xmlItems = doc.CreateElement("items");
                XmlElement xmlItem1 = doc.CreateElement("item1");
                XmlElement xmlItem2 = doc.CreateElement("item2");
                XmlElement xmlItem3 = doc.CreateElement("item3");
                XmlElement xmlItem4 = doc.CreateElement("item4");
                XmlElement xmlItem5 = doc.CreateElement("item5");
                XmlElement xmlItem6 = doc.CreateElement("item6");
                XmlElement xmlItem7 = doc.CreateElement("item7");

                doc.AppendChild(xmlItems);
                xmlItems.AppendChild(xmlItem1);
                xmlItems.AppendChild(xmlItem2);
                xmlItems.AppendChild(xmlItem3);
                xmlItems.AppendChild(xmlItem4);
                xmlItems.AppendChild(xmlItem5);
                xmlItems.AppendChild(xmlItem6);
                xmlItems.AppendChild(xmlItem7);

                xmlItem1.InnerText = item1.Text;
                xmlItem2.InnerText = item2.Text;
                xmlItem3.InnerText = item3.Text;
                xmlItem4.InnerText = item4.Text;
                xmlItem5.InnerText = item5.Text;
                xmlItem6.InnerText = item6.Text;
                xmlItem7.InnerText = item7.Text;

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.Encoding = System.Text.Encoding.UTF8;
                XmlWriter writer = XmlWriter.Create(path, settings);
                doc.WriteTo(writer);
                writer.Flush();
                writer.Close();
                MessageBox.Show("write finish.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
    }
}