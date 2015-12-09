using System.Linq;
using Novacode;

namespace _05.WordDocumentGenerator
{
    class WordDocumentGenerator
    {
        static void Main()
        {
            CreateSampleDocument();
        }

        public static void CreateSampleDocument()
        {
            using (DocX document = DocX.Create("../../MyDocXDocument.docx"))
            {
                Paragraph headLine = document.InsertParagraph();
                string headLineText = "SoftUni OOP Game Contest";
                headLine.AppendLine(headLineText).Bold().FontSize(32);
                headLine.Alignment = Alignment.center;

                Image imageGame = document.AddImage("../../rpg-game.png");
                Paragraph pictureParagraph = document.InsertParagraph("", false);
                Picture game = imageGame.CreatePicture(250, 600);
                pictureParagraph.InsertPicture(game);

                Paragraph text = document.InsertParagraph();
                text.AppendLine();
                text.Append("SoftUni is organizing a contest for the best ");
                text.Append("role playing game").Bold();
                text.Append(" from the OOP teamwork\n projects. The winning teams will receive a ");
                text.Append("grand prize").Bold().UnderlineStyle(UnderlineStyle.singleLine);
                text.Append("!\nThe game should be:");

                List bullets = document.AddList(null, 0, ListItemType.Bulleted);
                document.AddListItem(bullets, "Properly structured and follow all good OOP practices");
                document.AddListItem(bullets, "Awesome");
                document.AddListItem(bullets, "..Very Awesome");
                document.InsertList(bullets);
                document.InsertParagraph("\n");

                Table table = document.AddTable(4, 3);
                table.Alignment = Alignment.center;
                table.Rows[0].Cells[0].Paragraphs.First().Append("Team").Bold();
                table.Rows[0].Cells[0].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[1].Paragraphs.First().Append("Game").Bold();
                table.Rows[0].Cells[1].Paragraphs.First().Alignment = Alignment.center;
                table.Rows[0].Cells[2].Paragraphs.First().Append("Points").Bold();
                table.Rows[0].Cells[2].Paragraphs.First().Alignment = Alignment.center;

                for (int i = 1; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        table.Rows[i].Cells[j].Paragraphs.First().Append("-");
                        table.Rows[i].Cells[j].Paragraphs.First().Alignment = Alignment.center;
                    }
                }

                table.Rows[0].Cells.ForEach(c => c.Width = 300);
                table.Rows[1].Cells.ForEach(c => c.Width = 300);
                table.Rows[2].Cells.ForEach(c => c.Width = 300);
                document.InsertTable(table);

                Paragraph finalParagraph = document.InsertParagraph();
                finalParagraph.AppendLine();
                finalParagraph.Append("The top 3 teams will receive a ");
                finalParagraph.Append("SPECTACULAR").Bold().FontSize(16);
                finalParagraph.Append(" prize:\n");
                finalParagraph.Append("A HANDSHAKE FROM NAKOV").Bold().FontSize(24).UnderlineStyle(UnderlineStyle.singleLine);
                finalParagraph.Alignment = Alignment.center;
                document.Save();
            }
        }
    }
}
