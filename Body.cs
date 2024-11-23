using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Body
{
	protected double hight { get; set; }
	protected double weight { get; set; }
	protected double chest { get; set; }
	public Body(double H, double W, double C)
	{
		this.hight = H;
		this.weight = W;
		this.chest = C;
	}
	public void tInt()
	{
		this.hight = Math.Round(this.hight);
		this.weight = Math.Round(this.weight);
		this.chest = Math.Round(this.chest);
	}
	public override string ToString()
	{
		return $"Рост: {hight}\nВес: {weight}\nОбхват груди: {chest}";
	}
}