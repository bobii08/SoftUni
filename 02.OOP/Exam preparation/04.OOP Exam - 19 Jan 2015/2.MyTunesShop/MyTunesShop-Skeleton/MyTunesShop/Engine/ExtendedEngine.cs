using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTunesShop.Interfaces;
using MyTunesShop.Models;

namespace MyTunesShop.Engine
{
    public class ExtendedEngine : MyTunesEngine
    {
        protected override void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "song_to_album":
                    string albumName = commandWords[2];
                    string songName = commandWords[3];
                    var album = this.media.FirstOrDefault(m => m is Album && m.Title == albumName) as Album;
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }
                    var song = this.media.FirstOrDefault(m => m is Song && m.Title == songName) as Song;
                    if (song == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }
                    this.ExecuteAddSongToAlbum(album, song);
                    this.Printer.PrintLine("The song {0} has been added to the album {1}.", songName, albumName);
                    break;
                    //insert:member_to_band:Godsmack:Shannon Larkin
                case "member_to_band":
                    var bandName = commandWords[2];
                    var band = this.performers.FirstOrDefault(p => p.Name == bandName) as IBand;
                    if (band == null)
                    {
                        this.Printer.PrintLine("The band does not exist in the database.");
                        return;
                    }
                    band.AddMember(commandWords[3]);
                    this.Printer.PrintLine("The member {0} has been added to the band {1}.", commandWords[3], band.Name);
                    break;
                default:
                    base.ExecuteInsertCommand(commandWords);
                    break;
            }
        }
        //supply:album;IV;30
        protected override void ExecuteSupplyCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(s => s is IAlbum && s.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    int quantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[album].Supply(quantity);
                    this.Printer.PrintLine("{0} items of album {1} successfully supplied.", quantity, album.Title);
                    break;
                default:
                    base.ExecuteSupplyCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSellCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(s => s is IAlbum && s.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    int quantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[album].Sell(quantity);
                    this.Printer.PrintLine("{0} items of album {1} successfully sold.", quantity, album.Title);
                    break;
                default:
                    base.ExecuteSellCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "band":
                    var band = this.performers.FirstOrDefault(p => p is IBand && p.Name == commandWords[3]) as IBand;
                    if (band == null)
                    {
                        this.Printer.PrintLine("The band does not exist in the database.");
                        return;
                    }

                    this.Printer.PrintLine(this.GetBandReport(band));
                    break;
                default:
                    base.ExecuteReportPerformerCommand(commandWords);
                    break;
            }
        }

        private string GetBandReport(IBand band)
        {
            StringBuilder bandInfo = new StringBuilder();
            bandInfo.Append(band.Name + ": ");
            if (band.Members.Any())
            {
                bandInfo.Append(string.Join(", ", band.Members));
            }
            bandInfo.AppendLine();
            if (band.Songs.Any())
            {
                var songs = band.Songs
                    .Select(s => s.Title)
                    .OrderBy(s => s);
                bandInfo.Append(string.Join("; ", songs));
            }
            else
            {
                bandInfo.Append("no songs");
            }

            return bandInfo.ToString();
        }
        
        protected override void ExecuteInsertPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "band":
                    var band = new Band(commandWords[3]);
                    this.InsertPerformer(band);
                    break;
                default:
                    base.ExecuteInsertPerformerCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var album = this.media.FirstOrDefault(s => s is IAlbum && s.Title == commandWords[3]) as IAlbum;
                    if (album == null)
                    {
                        this.Printer.PrintLine("The song does not exist in the database.");
                        return;
                    }

                    this.Printer.PrintLine(this.GetAlbumReport(album));
                    break;
                default:
                    base.ExecuteReportMediaCommand(commandWords);
                    break;
            }
        }

        private string GetAlbumReport(IAlbum album)
        {
            var albumSalesInfo = this.mediaSupplies[album];
            StringBuilder albumInfo = new StringBuilder();
            albumInfo.AppendFormat("{0} ({1}) by {2}", album.Title, album.Year, album.Performer.Name).AppendLine()
                .AppendFormat("Genre: {0}, Price: ${1:F2}", album.Genre, album.Price).AppendLine()
                .AppendFormat("Supplies: {0}, Sold: {1}", albumSalesInfo.Supplies, albumSalesInfo.QuantitySold).AppendLine();
            if (album.Songs.Any())
            {
                var songs = album.Songs
                    .Select(s => s.Title + " (" + s.Duration + ")");
                albumInfo
                    .AppendLine("Songs:")
                    .Append(string.Join(Environment.NewLine, songs));
            }
            else
            {
                albumInfo.Append("No songs");
            }

            return albumInfo.ToString();
        }

        private void ExecuteAddSongToAlbum(Album album, Song song)
        {
            album.Songs.Add(song);
        }

        protected override string GetSongReport(ISong song)
        {
            var songSalesInfo = this.mediaSupplies[song];
            StringBuilder songInfo = new StringBuilder();
            songInfo.AppendFormat("{0} ({1}) by {2}", song.Title, song.Year, song.Performer.Name).AppendLine()
                .AppendFormat("Genre: {0}, Price: ${1:F2}", song.Genre, song.Price).AppendLine()
                .AppendFormat("Rating: {0:F0}", song.Ratings.Any() ? song.Ratings.Average() : 0).AppendLine()
                .AppendFormat("Supplies: {0}, Sold: {1}", songSalesInfo.Supplies, songSalesInfo.QuantitySold);
            return songInfo.ToString();
        }

        // rate:song;7 Years;5
        protected override void ExecuteRateCommand(string[] commandWords)
        {
            var songTitle = commandWords[2];
            var song = this.media.FirstOrDefault(m => m is ISong && m.Title == songTitle) as ISong;
            song.PlaceRating(int.Parse(commandWords[3]));
            this.Printer.PrintLine("The rating has been placed successfully.");
        }

        protected override void ExecuteInsertMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var performer = this.performers.FirstOrDefault(p => p.Name == commandWords[5]);
                    if (performer == null)
                    {
                        this.Printer.PrintLine("The performer does not exist in the database.");
                        return;
                    }

                    var album = new Album(
                        commandWords[3],
                        decimal.Parse(commandWords[4]),
                        performer,
                        commandWords[6],
                        int.Parse(commandWords[7]));
                    this.InsertAlbum(album, performer);
                    break;
                default:
                    base.ExecuteInsertMediaCommand(commandWords);
                    break;
            }
        }

        private void InsertAlbum(Album album, IPerformer performer)
        {
            this.media.Add(album);
            this.mediaSupplies.Add(album, new SalesInfo());
            this.Printer.PrintLine("Album {0} by {1} added successfully",
                album.Title, performer.Name);
        }
    }
}
