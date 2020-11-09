using DlibDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceRecognitionDotNet;
using System.Windows.Forms;

namespace Sistema
{
    public class UsuarioDAO
    {
        public static string capturarImagem()
        {
            string a = null;

            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "Imagem | *.jpg; *.jpeg;";
                if (o.ShowDialog() == DialogResult.OK)
                { a = o.FileName; }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao capturar a imagem!", ex);
            }
            return a;
        }

        public static void Cadastrar(string caminho)
        {

            // processo de salvar

        }

        public static UsuarioTO Logar(string caminho)
        {
            //.5G79jSAEk3Jdps (EoTs%nVcVU1yxwzY1^#
            UsuarioTO u = null;

            var a = FaceRecognitionDotNet.FaceRecognition.LoadImageFile(caminho, Mode.Rgb);

            var so = FaceRecognitionDotNet.FaceRecognition.LoadImage((System.Drawing.Bitmap)System.Drawing.Image.FromFile(caminho));            


            // set up Dlib facedetector
            using (var fd = Dlib.GetFrontalFaceDetector())
            {
                Array2D<RgbPixel> img = Dlib.LoadImage<RgbPixel>(caminho);

                DlibDotNet.Rectangle[] faces = fd.Operator(img);

                foreach (DlibDotNet.Rectangle face in faces)
                {
                    //var shape = sp.Detect(img, face);
                    //var faceChipDetail = Dlib.GetFaceChipDetails(shape, 150, 0.25);
                    //var faceChip = Dlib.ExtractImageChip<RgbPixel>(img, faceChipDetail);

                    Dlib.DrawRectangle(img, face, color: new RgbPixel(0, 255, 255), thickness: 4);
                    Dlib.ex

                }

                Dlib.SavePng(img, @"C:\Users\Nanokaso\Pictures\Saved Pictures\rostos\" + Guid.NewGuid().ToString().Replace("-", "") + ".png");
            }

            // processo de logar


            u = new UsuarioTO();
            u.Nome = "Teste";

            return u;
        }

        public static void Deletar(UsuarioTO user)
        {

        }
    }
}
