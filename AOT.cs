using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class AOT : Body
{
	private string titan_name { get; set; }
    private double titan_h_cof { get; set; }
    private double titan_w_cof { get; set; }

	public AOT(string titan_name, double titan_h_cof, double titan_w_cof, double hight, double weight, double chest) : base(hight, weight, chest)
	{
		this.titan_name = titan_name;
		this.titan_h_cof = titan_h_cof;
		this.titan_w_cof = titan_w_cof;
	}


	public void ToTitan()
	{
		this.hight *= titan_h_cof;
		this.chest *= titan_h_cof;
		this.weight *= titan_w_cof;

	}
	public long SkreemArea()
	{
		return (long)(this.chest * 8 / 27);
	}
}