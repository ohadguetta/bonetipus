//Generate
        private void Generate()
        {
            string[] clist = listBox1.Items.OfType<string>().ToArray();
            richTextBox1.Clear();

            if (label4.Text == "")
            {
                MessageBox.Show("נא לכתוב שם טיפוס");

            }
            else if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("נא לשים תכונות");
            }
            else
            {
                //תכונות
                richTextBox1.AppendText("class " + FirstCharToUpper(label4.Text) + "\n" + "{" + "\n");
                foreach (object item in listBox1.Items)
                {
                    if (item.ToString().Contains("-string"))
                    {

                        string PureItem = item.ToString().Replace(" -string", "");
                        richTextBox1.AppendText("private string " + PureItem + ";");
                        richTextBox1.AppendText("\n");
                    }
                    if (item.ToString().Contains("-int"))
                    {
                        string PureItem = item.ToString().Replace(" -int", "");
                        richTextBox1.AppendText("private int " + PureItem + ";");
                        richTextBox1.AppendText("\n");
                    }
                    if (item.ToString().Contains("-double"))
                    {

                        string PureItem = item.ToString().Replace(" -double", "");
                        richTextBox1.AppendText("private double " + PureItem + ";");
                        richTextBox1.AppendText("\n");
                    }

                }
                richTextBox1.AppendText("\n");

                //  פעולה בונה
                richTextBox1.AppendText("public " + FirstCharToUpper(label4.Text) + " (");
                foreach (object item in listBox1.Items)
                {



                    if (item.ToString().Contains("-string"))
                    {

                        string PureItem = item.ToString().Replace(" -string", "");
                        richTextBox1.AppendText("string " + PureItem);

                    }
                    if (item.ToString().Contains("-int"))
                    {
                        string PureItem = item.ToString().Replace(" -int", "");
                        richTextBox1.AppendText("int " + PureItem);

                    }
                    if (item.ToString().Contains("-double"))
                    {

                        string PureItem = item.ToString().Replace(" -double", "");
                        richTextBox1.AppendText("double " + PureItem);

                    }
                    var lastWord = clist[clist.Count() - 1];
                    if (item != lastWord)
                    {
                        richTextBox1.AppendText(",");
                    }
                    //    MessageBox.Show(lastWord);
                }
                richTextBox1.AppendText(")" + "\n" + "{" + "\n");

                //פעולה בונה חלק 2
                foreach (object item in listBox1.Items)
                {



                    if (item.ToString().Contains("-string"))
                    {

                        string PureItem = item.ToString().Replace(" -string", "");
                        richTextBox1.AppendText("this." + PureItem + " = " + PureItem + ";");

                    }
                    if (item.ToString().Contains("-int"))
                    {
                        string PureItem = item.ToString().Replace(" -int", "");
                        richTextBox1.AppendText("this." + PureItem + " = " + PureItem + ";");

                    }
                    if (item.ToString().Contains("-double"))
                    {

                        string PureItem = item.ToString().Replace(" -double", "");
                        richTextBox1.AppendText("this." + PureItem + " = " + PureItem + ";");

                    }
                    richTextBox1.AppendText("\n");
                    //    MessageBox.Show(lastWord);
                }
                richTextBox1.AppendText("}");
                richTextBox1.AppendText("\n");
                richTextBox1.AppendText("\n");

                //פעולות מאחזרות
                foreach (object item in listBox1.Items)
                {
                    if (item.ToString().Contains("-string"))
                    {


                        string PureItem = item.ToString().Replace(" -string", "");
                        richTextBox1.AppendText("public string Get" + Program.ToUpperFirstLetter(PureItem) + "()" + "\n" + "{" + "\n" + "return this." + PureItem + ";" + "\n" + "}");

                    }
                    if (item.ToString().Contains("-int"))
                    {

                        string PureItem = item.ToString().Replace(" -int", "");
                        richTextBox1.AppendText("public int Get" + Program.ToUpperFirstLetter(PureItem) + "()" + "\n" + "{" + "\n" + "return this." + PureItem + ";" + "\n" + "}");


                    }
                    if (item.ToString().Contains("-double"))
                    {

                        string PureItem = item.ToString().Replace(" -double", "");
                        richTextBox1.AppendText("public double Get" + Program.ToUpperFirstLetter(PureItem) + "()" + "\n" + "{" + "\n" + "return this." + PureItem + ";" + "\n" + "}");

                    }



                    richTextBox1.AppendText("\n");



                }
                richTextBox1.AppendText("\n");
                //פעולות מעדכנות
                foreach (object item in listBox1.Items)
                {
                    if (item.ToString().Contains("-string"))
                    {

                        string PureItem = item.ToString().Replace(" -string", "");
                        richTextBox1.AppendText("public void Set" + Program.ToUpperFirstLetter(PureItem) + "(" + "string " + PureItem + ")" + "\n" + "{" + "\n" + "this." + PureItem + "= " + PureItem + ";" + "\n" + "}");
                        richTextBox1.AppendText("\n");
                    }
                    if (item.ToString().Contains("-int"))
                    {
                        string PureItem = item.ToString().Replace(" -int", "");
                        richTextBox1.AppendText("public void Set" + Program.ToUpperFirstLetter(PureItem) + "(" + "int " + PureItem + ")" + "\n" + "{" + "\n" + "this." + PureItem + "= " + PureItem + ";" + "\n" + "}");
                        richTextBox1.AppendText("\n");
                    }
                    if (item.ToString().Contains("-double"))
                    {
                        string PureItem = item.ToString().Replace(" -double", "");
                        richTextBox1.AppendText("public void Set" + Program.ToUpperFirstLetter(PureItem) + "(" + "double " + PureItem + ")" + "\n" + "{" + "\n" + "this." + PureItem + "= " + PureItem + ";" + "\n" + "}");
                        richTextBox1.AppendText("\n");
                    }



                    richTextBox1.AppendText("\n");

                }

                //ToString method
                if (checkBox1.Checked == true)
                {


                    richTextBox1.AppendText("public string ToString() {" + "\n");
                    richTextBox1.AppendText("return \"");
                    foreach (object item in listBox1.Items)
                    {

                        if (item.ToString().Contains("-string"))
                        {

                            string PureItem = item.ToString().Replace(" -string", "");
                            richTextBox1.AppendText(PureItem + "=\"+ " + "this." + PureItem);

                        }
                        if (item.ToString().Contains("-int"))
                        {
                            string PureItem = item.ToString().Replace(" -int", "");
                            richTextBox1.AppendText(PureItem + "=\"+ " + "this." + PureItem);

                        }
                        if (item.ToString().Contains("-double"))
                        {

                            string PureItem = item.ToString().Replace(" -double", "");
                            richTextBox1.AppendText(PureItem + "=\"+ " + "this." + PureItem);

                        }
                        var lastWord = clist[clist.Count() - 1];
                        if (item != lastWord)
                        {
                            richTextBox1.AppendText("+" + "\" ");
                        }
                    }
                    richTextBox1.AppendText(";" + "\n }");

                }
                richTextBox1.AppendText("\n }");
            }//end of else

        }
        //Generate
