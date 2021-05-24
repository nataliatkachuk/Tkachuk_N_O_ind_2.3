using System;
using System.IO;

namespace UserFormsExample
{
	public class car
	{
		public string Mark { get; set; }
		public string Model { get; set; }
		public string nomer { get; set; }
		public string way { get; set; }
		public byte sitplace { get; set; }

		public car()
		{
			
		}

		public car(string mark, string model, string nomer, string way, byte sitplace = 0)
		{
			this.Mark = mark;
			this.Model = model;
			this.nomer = nomer;
			this.way = way;
			this.sitplace = sitplace;
		}

		public override string  ToString()
		{
			return Mark + " " + Model + " " + nomer + " " + way + "" + sitplace;
		}
		
		public void Write(BinaryWriter stream)
		{
			stream.Write(Mark);
			stream.Write(Model);
			stream.Write(nomer);
			stream.Write(way);
			stream.Write(sitplace);
			
		}
		
		public void Read(BinaryReader stream)
		{
			Mark = stream.ReadString();
			Model = stream.ReadString();
			nomer = stream.ReadString();
			way = stream.ReadString();
			sitplace = stream.ReadByte();
			//stream.
		}		
		
	}
}
