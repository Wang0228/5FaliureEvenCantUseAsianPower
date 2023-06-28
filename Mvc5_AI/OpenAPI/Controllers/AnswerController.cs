using Microsoft.AspNetCore.Mvc;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using openAPI.Models;

namespace openAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pdfController : ControllerBase//砍掉的未完成pdf處理專案 先幫你QQ
    {
        private readonly Hkcontext _hkcontext;
        public pdfController(Hkcontext hkcontext)
        {
            _hkcontext = hkcontext;
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            EmbeddingController embedding = new EmbeddingController();
            PdfReader reader = new PdfReader("./PDF/華電.pdf");
            string text = string.Empty;
            List<string> groupedSentences = new List<string>();//中文集
            for (int page = 21; page <= 21; page++)//reader.NumberOfPages
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);//讀取當頁的字
                string[] separators = { ".", "!", "。" };//遇到這些會切斷
                List<string> sentences = text.Split(separators, StringSplitOptions.RemoveEmptyEntries)//將text分句依序存到sentences裡面
                                             .Select(s => s.Trim())
                                             .ToList();


                int sentenceCount = sentences.Count;
                int groupSize = 3;//設定每幾句要當一組字串
                int groupCount = (int)Math.Ceiling((double)sentenceCount / groupSize);//設定下面的迴圈要跑幾run

                for (int i = 0; i < groupCount; i++)
                {
                    int startIndex = i * groupSize;
                    int endIndex = Math.Min(startIndex + groupSize, sentenceCount);//防止超出範圍
                    List<string> group = sentences.GetRange(startIndex, endIndex - startIndex);
                    groupedSentences.Add(string.Join(" ", group));
                }

            }

            reader.Close();
            foreach(var sentences in groupedSentences)
            {
                _hkcontext.Embeddings.Add(new Embedding { EmbeddingQuestion = "test", EmbeddingAnswer = "test", Qa = sentences, EmbeddingVectors = "test" });
                _hkcontext.SaveChanges();
            }
            return Ok(groupedSentences);
        }
    }    
}
