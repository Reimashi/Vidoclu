using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Vidoclu
{
    public class FileManager
    {
        private String name;

        // Headers guarda el nombre de las cabeceras
        private String[] headers;
        private List<String[]> data = new List<string[]>();
        private Int32 dataIndex;

        public FileManager(String name, String[] headers)
        {
            this.name = name;
            this.headers = headers;
        }

        public Boolean Load()
        {
            try
            {
                this.dataIndex = 0;
                this.data.Clear();
            }
            catch { }

            try
            {
                FileStream stream = new FileStream("./db/" + name + ".dat", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    AddRegistry(reader.ReadLine());
                }
                reader.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void AddRegistry(String line)
        {
            String[] aux;

            aux = line.Split('#');

            AddRegistry(aux);
        }

        public void AddNewRegistry(String line)
        {
            String[] aux;

            aux = line.Split('#');

            AddNewRegistry(aux);
        }

        public void AddNewRegistry(String line, String Id)
        {
            String[] aux;

            aux = line.Split('#');

            AddNewRegistry(aux, Id);
        }

        public void AddRegistry(String[] data)
        {
            this.data.Add(data);
            dataIndex++;
        }

        public void AddNewRegistry(String[] data)
        {
            String[] aux = new String[data.Length + 1];

            aux[0] = generateID();

            for (int i = 0; i < data.Length; i++)
            {
                aux[i + 1] = data[i];
            }

            this.data.Add(aux);
            dataIndex++;
        }

        public void AddNewRegistry(String[] data, String Id)
        {
            String[] aux = new String[data.Length + 1];

            aux[0] = Id;

            for (int i = 0; i < data.Length; i++)
            {
                aux[i + 1] = data[i];
            }

            this.data.Add(aux);
            dataIndex++;
        }

        public string generateID()
        {
            Random r = new Random();
            String aux = "";

            Boolean bucle = true;

            while (bucle)
            {
                aux = r.Next(00000, 99999).ToString();

                if (0 < dataIndex)
                {
                    for (int i = 0; i < dataIndex; i++)
                    {
                        if (aux == data[i][0])
                        {
                            bucle = true;
                            break;
                        }

                        bucle = false;
                    }
                }
                else
                    bucle = false;
            }

            return aux;
        }

        public String[] GetRegistryWithID(Int32 index)
        {
            if (index < 0 || index > dataIndex - 1)
            {
                return null;
            }
            else
            {
                return data[index];
            }
        }

        public String[] GetRegistry(Int32 index)
        {
            if (index < 0 || index > dataIndex - 1)
            {
                return null;
            }
            else
            {
                String[] aux = new String[data[index].Length - 1];

                for (int i = 1; i < this.data[index].Length; i++)
                {
                    aux[i - 1] = data[index][i];
                }

                return aux;
            }
        }

        public Boolean DeleteRegistry(Int32 index)
        {
            if (index < 0 || index > dataIndex - 1)
            {
                return false;
            }
            else
            {
                List<String[]> dataaux = new List<string[]>();
                for (int j = 0; j < index; j++)
                    dataaux.Add(data[j]);

                for (int i = index; i < dataIndex - 1; i++) //
                {
                    dataaux.Add(data[i + 1]);
                }

                this.data = dataaux;

                dataIndex--;
                return true;
            }
        }

        public Boolean ModifyRegistry(Int32 index, String data)
        {
            String[] aux;

            aux = data.Split('#');

            return ModifyRegistry(index, aux);
        }

        public Boolean ModifyRegistry(Int32 index, String[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                this.data[index][i + 1] = data[i];
            }

            return true;
        }

        public Int32 GetIndexByID(String Id)
        {
            for (int i = 0; i < dataIndex; i++)
            {
                if (this.data[i][0] == Id)
                    return i;
            }

            return -1;
        }

        public Boolean Save()
        {
            try
            {
                FileStream stream = new FileStream("./db/" + name + ".dat", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);

                for (int i = 0; i < dataIndex; i++)
                {
                    writer.WriteLine(Encode(data[i]));
                }

                writer.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static String Encode(String[] line)
        {
            String aux = "";

            if (line == null)
            {
                return aux;
            }

            for (int i = 0; i < line.Length; i++)
            {
                aux += line[i];
                if (i + 1 < line.Length)
                {
                    aux += '#';
                }
            }

            return aux;
        }

        public Int32 WEIGHT
        {
            get { return dataIndex; }
        }

        public Int32 MAX_INDEX
        {
            get { return dataIndex - 1; }
        }

        public String[] HEADERS
        {
            get { return this.headers; }
        }
    }
}
