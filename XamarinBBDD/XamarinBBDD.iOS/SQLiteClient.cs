using Foundation;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using UIKit;
using XamarinBBDD.Dependencies;
using XamarinBBDD.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteClient))]
namespace XamarinBBDD.iOS
{
    public class SQLiteClient : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            String bbddfile = "HOSPITAL.db";
            String rutadocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            String librarypath = Path.Combine(rutadocuments, "...", "Library", "Databases");

            if (Directory.Exists(librarypath) == false)
            {
                Directory.CreateDirectory(librarypath);
            }

            String path = Path.Combine(librarypath, bbddfile);
            SQLiteConnection cn = new SQLiteConnection(path);
            return cn;

        }
    }
}