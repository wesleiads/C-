using System;
using System.IO;
using System.Collections.Generic;

namespace servico
{
    class Usuario
    {
        static int UID = 0;

        int id;
        string username;
        string hash;

        public Usuario(string u, string p)
        {
            id = getUID();
            setUsername(u);
            ApplyHash(p);
        }

        static int getUID()
        {
            UID++;
            return UID;
        }

        void ApplyHash(string password)
        {
            hash = password;
        }

        public string getUsername()
        {
            return username;
        }

        public string getHash()
        {
            return hash;
        }

        public string Serialize()
        {
            return id + "," + username + "," + hash;
        }

        public void setUsername(string u)
        {
            username = u;
        }
    }

    class UserBase
    {
        string filename;

        List<Usuario> usuarios;

        public UserBase(string f)
        {
            filename = f;
            usuarios = new List<Usuario>();
            LoadUsers();
        }

        void LoadUsers()
        {
        }

        public void Adduser(Usuario u)
        {
            usuarios.Add (u);
        }

        public void Save()
        {
            string output = "";
            foreach (Usuario u in usuarios)
            {
                output += u.Serialize() + "\n";
            }
            File.WriteAllText (filename, output);
        }
    }
}
