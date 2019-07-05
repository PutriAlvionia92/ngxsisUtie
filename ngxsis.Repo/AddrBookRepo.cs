﻿using ngxsis.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngxsis.Repo
{

    public class AddrBookRepo
    {
        public static x_addrbook GetUname(string Uname)
        {
     
            x_addrbook ab = new x_addrbook();
            using (DataContext db = new DataContext())
            {
                ab = db.x_addrbook.Where(d => d.email == Uname || d.abuid == Uname).FirstOrDefault();

                //string password = ab.abpwd;
                ////parameter untuk decode password md5 
                //System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                //System.Text.Decoder utf8Decode = encoder.GetDecoder();
                //byte[] todecode_byte = Convert.FromBase64String(password);
                //int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                //char[] decoded_char = new char[charCount];
                //utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                //string result = new String(decoded_char);

                //ab.abpwd = result;
                //end parameter untuk decode password md5 


                return ab;
            }
        }

        public static Boolean EditAddrBook(int ID)
        {
            try
            {
                x_addrbook change;
                using (DataContext db = new DataContext())
                {
                    change = db.x_addrbook.Where(itm => itm.id == ID).First();
                    change.attempt += 1;
                    change.modified_on = DateTime.Now;
                    db.Entry(change).State = EntityState.Modified;
                    db.SaveChanges();

                    if(change.attempt == 3)
                    {
                        change.is_locked = true;
                        db.Entry(change).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public static Boolean clrAddrBook()
        {
            try
            {
                List<x_addrbook> result = new List<x_addrbook>();
                using (DataContext db = new DataContext())
                {
                    result = db.x_addrbook.Where(itm => itm.modified_on != null && itm.modified_on < DateTime.Today && itm.attempt < 3).ToList();
                    foreach(var item in result)
                    {
                        item.modified_on = null;
                        item.attempt = 0;
                        db.Entry(item).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
    }
}