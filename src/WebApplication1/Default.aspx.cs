using System;
using System.Text.RegularExpressions;
using Bjerner.LoremIpsum;
using Bjerner.LoremIpsum.Providers;

namespace WebApplication1 {
    
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            LoremIpsumGenerator generator = new LoremIpsumGenerator();

            foreach (string str in generator.MakeParagraphs()) {
                Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(str) + "</pre>\n";
            }

            Content.Text += "<hr />";

            Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(generator.MakeParagraph(LoremIpsumType.WordsAndFillers)) + "</pre>\n";
            Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(generator.MakeParagraph(LoremIpsumType.WordsAndFillers)) + "</pre>\n";
            Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(generator.MakeParagraph(LoremIpsumType.WordsAndFillers)) + "</pre>\n";

            Content.Text += "<hr />";

            foreach (string str in generator.MakeParagraphs(LoremIpsumType.Words)) {
                Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(str) + "</pre>\n";
            }

            Content.Text += "<hr />";

            Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(generator.MakeParagraph(LoremIpsumType.Words)) + "</pre>\n";
            Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(generator.MakeParagraph(LoremIpsumType.Words)) + "</pre>\n";
            Content.Text += "<pre style=\"white-space: pre-wrap;\">" + Validate(generator.MakeParagraph(LoremIpsumType.Words)) + "</pre>\n";

        }

        public static string Validate(string str) {

            bool valid = true;

            str = Regex.Replace(str, "(\\. [a-z])", delegate(Match match) {
                valid = false;
                return "<span style=\"background: #f7c8c8; color: #880000;\">" + match.Value + "</span>";
            });

            return "<span style=\"background: " + (valid ? "#dfd" : "#fdd") + ";\">" + str + "</span>";

        }
    
    }

}