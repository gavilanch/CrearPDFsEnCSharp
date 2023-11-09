// See https://aka.ms/new-console-template for more information

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;

QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

// Ejemplo 1: Hola mundo pdf.

//Document.Create(contenedor =>
//{
//    contenedor.Page(pagina =>
//    {
//        pagina.Size(PageSizes.A4);
//        pagina.Margin(1,
//            QuestPDF.Infrastructure.Unit.Centimetre);

//        pagina.Header().Text("Hola mundo!")
//        .Bold().FontSize(35)
//        .FontColor(Colors.Red.Medium);
//    });
//}).GeneratePdf("hola mundo.pdf");

// Ejemplo 2: Un pdf más complejo

Document.Create(contenedor =>
{
    contenedor.Page(pagina =>
    {
        pagina.Size(PageSizes.A4);

        pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);

        pagina.Header().Text("Aprendamos .NET")
        .Bold().FontSize(35).FontColor(Colors.Red.Medium);

        pagina.Content().Column(columna =>
        {
            columna.Spacing(20);
            columna.Item().Text(Placeholders.LoremIpsum());
            columna.Item().Image(Placeholders.Image(200, 100));

            columna.Item().Row(row =>
            {
                row.Spacing(20);

                row.RelativeItem().Column(c1 =>
                {
                    c1.Item().Text(Placeholders.LoremIpsum());
                    c1.Item().Image(Placeholders.Image(200, 100));
                });

                row.RelativeItem().Column(c1 =>
                {
                    c1.Item().Text(Placeholders.LoremIpsum());
                    c1.Item().Image(Placeholders.Image(200, 100));
                });
            });

            columna.Item().Row(row =>
            {
                row.Spacing(20);

                row.RelativeItem().Column(c1 =>
                {
                    c1.Item().Text(Placeholders.LoremIpsum());
                    c1.Item().Image(Placeholders.Image(200, 100));
                });

                row.RelativeItem().Column(c1 =>
                {
                    c1.Item().Text(Placeholders.LoremIpsum());
                    c1.Item().Image(Placeholders.Image(200, 100));
                });

                row.RelativeItem().Column(c1 =>
                {
                    c1.Item().Text(Placeholders.LoremIpsum());
                    c1.Item().Image(Placeholders.Image(200, 100));
                });
            });


        });

        pagina.Footer().AlignCenter().Text(x =>
        {
            x.CurrentPageNumber();
            x.Span(" / ");
            x.TotalPages();
        });
    });
}).ShowInPreviewer();

Console.WriteLine("Hello, World!");
