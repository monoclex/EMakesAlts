using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerIOClient;
using System.IO.Advanced;
using System.Threading;
using System.Net;

namespace EMakesAlts
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Data = new IO(fileLocation.Text, true);
			ran = new Random();
			ran.Next(0, 1000);

			altNumber.Text = Data["num"];
			altUsername.Text = Data["username"];
			altPassword.Text = Data["pass"];
			altEmail.Text = Data["email"];
			gameId.Text = Data["gameid"];

			Cracking_Code = new Thread(delegate()
			{

				while (true)
				{
					string GameId = Data["gameid"];
					string Username = Data["username"];
					string Password = Data["pass"];
					string Email = Data["email"];

					int KeyId = 0;

					try
					{
						KeyId = Convert.ToInt32(Data["num"]);
					}
					catch { }

					CaptchaData = PlayerIO.QuickConnect.SimpleGetCaptcha(Data["gameid"], 100, 50);
					GetCaptchaImage = new Thread(delegate()
					{
						var request = WebRequest.Create(CaptchaData.CaptchaImageUrl);

						using (var response = request.GetResponse())
						using (var stream = response.GetResponseStream())
						{
							getCaptcha.Invoke((MethodInvoker)(() => getCaptcha.Image = Bitmap.FromStream(stream)));
						}
					});
					GetCaptchaImage.Start();
					bool Registered = false;
					while (!Registered)
					{
						if(UpdateData)
						{
							GameId = Data["gameid"];
							Username = Data["username"];
							Password = Data["pass"];
							Email = Data["email"];
							try
							{
								KeyId = Convert.ToInt32(Data["num"]);
							}
							catch { }
							UpdateData = false;
						}
						string Key;

						if (ManualSend)
						{
							Key = manualCaptcha.Text;
							manualCaptcha.Invoke((MethodInvoker)(() => manualCaptcha.Text = ""));
							ManualSend = false;
						}
						else
						{
							Key = GetKey();
						}

						try
						{
							Register = PlayerIO.QuickConnect.SimpleRegister(@"everybody-edits-su9rn58o40itdbnw69plyw",
								Username.Replace("%alt%", KeyId.ToString()),
								Password.Replace("%alt%", KeyId.ToString()),
								Email.Replace("%alt%", KeyId.ToString()),
								CaptchaData.CaptchaKey,
								Key,
								null, null, null);
							console.Invoke((MethodInvoker)(() => console.Text = "Key " + Key + " success, alt " + KeyId + " generated. Use " + Email.Replace("%alt%", KeyId.ToString()) + ", " + Password.Replace("%alt%", KeyId.ToString()) + " to login."));
							KeyId++;
							Data["num"] = KeyId.ToString();
							Registered = true;
							Code[0] = 0;
							Code[1] = 0;
							Code[2] = 0;
							Code[3] = 0;
						}
						catch (PlayerIORegistrationError e)
						{
							console.Invoke((MethodInvoker)(() => console.Text = "Key " + Key + " failed. ( " + e.Message + " )"));
						}
					}
				}
			});

			GetCaptchaImage_Code = new Thread(delegate()
			{
				var request = WebRequest.Create(CaptchaData.CaptchaImageUrl);

				using (var response = request.GetResponse())
				using (var stream = response.GetResponseStream())
				{
					getCaptcha.Invoke((MethodInvoker)(() => getCaptcha.Image = Bitmap.FromStream(stream)));
				}
			});

			Cracking = Cracking_Code;
			GetCaptchaImage = GetCaptchaImage_Code;
		}


		public int[] Code = new int[4] { 0, 0, 0, 0 };
		public bool UpdateData = false,
			ManualSend = false;

		public SimpleGetCaptchaOutput CaptchaData;
		public Thread Cracking;
		public Thread GetCaptchaImage;

		public Thread Cracking_Code;
		public Thread GetCaptchaImage_Code;

		public Client Register;
		public Random ran;
		public IO Data;

		public void panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawEllipse(new Pen(Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)), 5), new Rectangle(e.ClipRectangle.X - 2, e.ClipRectangle.Y - 2, 4, 4));
		}

		public void SaveData(object sender, EventArgs e)
		{
			Data["gameid"] = gameId.Text;
			Data["email"] = altEmail.Text;
			Data["pass"] = altPassword.Text;
			Data["username"] = altUsername.Text;
			altNumber.Text = Data["num"];
			altUsername.Text = Data["username"];
			altPassword.Text = Data["pass"];
			altEmail.Text = Data["email"];
			gameId.Text = Data["gameid"];
			UpdateData = true;
		}

		public void button1_Click(object sender, EventArgs e)
		{
			if (button1.Text == "Start Alt Creator")
			{
				Cracking.Start();
				button1.Enabled = false;
			}
			else if (button1.Text == "Stop Alt Creator")
			{
				Cracking.Abort();
				button1.Text = "Start Alt Creator";
			}
		}

		#region GetKey
		public string GetKey()
		{
			string ret = "";

			foreach (int i in Code)
			{
				switch (i)
				{
					case 0:
						ret += "a";
						break;
					case 1:
						ret += "b";
						break;
					case 2:
						ret += "c";
						break;
					case 3:
						ret += "d";
						break;
					case 4:
						ret += "e";
						break;
					case 5:
						ret += "f";
						break;
					case 6:
						ret += "g";
						break;
					case 7:
						ret += "h";
						break;
					case 8:
						ret += "i";
						break;
					case 9:
						ret += "j";
						break;
					case 10:
						ret += "k";
						break;
					case 11:
						ret += "l";
						break;
					case 12:
						ret += "m";
						break;
					case 13:
						ret += "n";
						break;
					case 14:
						ret += "o";
						break;
					case 15:
						ret += "p";
						break;
					case 16:
						ret += "q";
						break;
					case 17:
						ret += "r";
						break;
					case 18:
						ret += "s";
						break;
					case 19:
						ret += "t";
						break;
					case 20:
						ret += "u";
						break;
					case 21:
						ret += "v";
						break;
					case 22:
						ret += "w";
						break;
					case 23:
						ret += "x";
						break;
					case 24:
						ret += "y";
						break;
					case 25:
						ret += "z";
						break;
				}
			}

			if (Code[0] == 25)
			{
				Code[0] = 0;
				Code[1] = 0;
				Code[2] = 0;
				Code[3] = 0;
			}
			else if (Code[1] == 25)
			{
				Code[1] = 0;
				Code[0]++;
			}
			else if (Code[2] == 25)
			{
				Code[2] = 0;
				Code[1]++;
			}
			else if (Code[3] == 25)
			{
				Code[3] = 0;
				Code[2]++;
			}
			else
			{
				Code[3]++;
			}

			return ret;
		}
		#endregion

		public void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			ManualSend = true;
		}

		private void Closing(object sender, FormClosingEventArgs e)
		{
			Cracking.Abort();
			GetCaptchaImage.Abort();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			GetCaptchaImage = new Thread(delegate()
			{
				var request = WebRequest.Create(CaptchaData.CaptchaImageUrl);

				using (var response = request.GetResponse())
				using (var stream = response.GetResponseStream())
				{
					getCaptcha.Invoke((MethodInvoker)(() => getCaptcha.Image = Bitmap.FromStream(stream)));
				}
			});
		}
	}
}