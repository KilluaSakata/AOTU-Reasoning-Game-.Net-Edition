using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AOTU_Window_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button1.Visible = false;
            MessageBox.Show("有人来了……\n" +
"躲在某处里的某人望着后面越来越近的影子，紧了紧自己身上的衣服。\n" +
"那人的影子在月光下越拖越长。\n" +
"别过来……别过来……\n" +
"人影像是没有发现他一样，停住了，然后转身往另一个方向走去。\n" +
"确定那人已经离开，他松了一口气，转过头来，打算起身离开。只听到啊一声，\n" +
"下一刻，惨叫声划破了夜空。\n", "第一章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 重开局ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否重新开局？\n" +
                "您将丢失您当前的状态！\n", "重新开局", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)


                Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Button5.Visible = true;
            Button6.Visible = true;
            Button7.Visible = true;
            Button8.Visible = true;
            Button9.Visible = true;
            Button10.Visible = true;
            Button11.Visible = true;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
                if (CheckBox5.Checked == true)
                    if (CheckBox9.Checked == true)
                        if (CheckBox11.Checked == true)
                            if (CheckBox1.Checked == false)
                                if (CheckBox3.Checked == false)
                                    if (CheckBox4.Checked == false)
                                        if (CheckBox6.Checked == false)
                                            if (CheckBox7.Checked == false)
                                                if (CheckBox8.Checked == false)
                                                    if (CheckBox10.Checked == false)
                                                        if (CheckBox12.Checked == false)
                                                            if (CheckBox13.Checked == false)
                                                                if (CheckBox14.Checked == false)
                                                                    if (CheckBox15.Checked == false)
                                                                        if (CheckBox16.Checked == false)
                                                                            MessageBox.Show("恭喜！全部正确！\n", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (CheckBox2.Checked == false)
                if (CheckBox5.Checked == false)
                    if (CheckBox9.Checked == false)
                        if (CheckBox11.Checked == false)
                            MessageBox.Show("没有选择到正确选项！请仔细检查您的答案！\n", "结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Button2.Visible = false;
            MessageBox.Show("顷刻间学院后山就挤满了人。\n" +
"空气里弥漫的血腥味告诉了来人，这里刚刚发生了什么。\n" +
"腹部被贯穿的紫堂幻靠在树上，镜片碎裂，面带惊恐，身旁还有倒地的三个小斯巴达。\n" +
"看上去几乎是没有反抗就被杀死的，但看到这一切的人们都没有对此疑惑。\n" +
"毕竟紫堂幻的实力摆在那里。\n" +
"没人打算去管这件事，大家很默契的散开了。\n" +
"格瑞听说紫堂幻被杀后第一件事就是瞒着和紫堂幻同宿舍的金，自己趁夜先去一探究竟。\n" +
"路上遇到了同样打算去凑个热闹的雷狮。\n" +
"二人来的时候，紫堂幻还是躺在那里，伤口上的血液几乎快要凝固了。\n" +
"[有些人为了积分什么都干得出来。]雷狮把自己的想法说了出来，[排名高的不敢动，紫堂幻和你还有那个小子组了那么久的队，积分也不菲。加上实力这么弱……]\n" +
"[事情没那么简单。] 格瑞看着紫堂幻的手势似乎是在保护着什么，便皱了皱眉头。\n" +
"随即一个微小的动作被他捕捉到了。\n", "第二章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Button3.Visible = false;
            MessageBox.Show("紫堂幻死亡的消息很快就传遍了整个校园。同宿舍的金更是被一些关注这件事的人推上了风口浪尖。\n" +
"紫堂幻实力本来就弱，人缘又不好，从头到尾只有金和凯莉以及高年级学长鬼狐天冲他接触过。\n" +
"而鬼狐天冲这几天都不在校。\n" +
"凯莉更有同宿舍的安莉洁作证没有出去过。\n" +
"[祖玛，你怎么看。]雷德凑过去问了问一边的蒙特祖玛。\n" +
"而蒙特祖玛根本懒得理他，直接转头似是要问嘉德罗斯的意见。\n" +
"而嘉德罗斯此时的眼中只有对面楼格瑞手上抱着东西走进了金的宿舍。\n" +
"那个似乎很像是某位已经死去的人的宠物。\n" +
"[呵。]\n" +
"[走，我们去找格瑞的麻烦去。]\n", "第三章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button4.Visible = false;
            MessageBox.Show("人们的猜测被事实推翻了。\n" +
"金死了，死在了自己的宿舍里。\n" +
"宿舍的门被嘉德罗斯踹开的那一刻，嘉德罗斯看见的一幕是格瑞看着金久久未动。\n" +
"金的身体上是一个巨大的窟窿，脸上写满了不可置信。\n" +
"[格瑞？]\n" +
"嘉德罗斯识趣地没有把下面的话接上去。\n" +
"他当然没有把怀疑的目光放在格瑞身上，那么大的窟窿虽然很有可能是烈斩造成的。\n" +
"但他和格瑞上次打架后烈斩已经被送去寒冰湖修理了，这是嘉德罗斯亲眼看见的。\n", "第四章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button5.Visible = false;
            MessageBox.Show("校园里的恐怖气氛越来越浓重了。\n" +
"格瑞这几天受到了一大群人的异样眼光，唯有同年级的雷狮以及同宿舍的安迷修愿意相信他不是杀了金的凶手。\n" +
"[我出去一下。]\n" +
"[慢着，嘉德罗斯说你进金的宿舍的时候有抱着一样东西，方便给我们看一下吗？]\n" +
"安迷修拉住了正要离开的格瑞。\n" +
"[好。]\n" +
"说着格瑞就去自己床榻下找什么东西。\n" +
"[……谁动过我东西了？]\n" +
"找了半天，格瑞起身，几乎是以质问的语气对着安迷修和雷狮说的。\n" +
"[会不会落在金的宿舍里了？]\n" +
"[安迷修，你先去那边找一下，我马上来。] 雷狮在对上格瑞的眼睛的时候就仿佛知道了什么，催着安迷修就是先去找。\n" +
"安迷修出了门后，便往金的宿舍的反方向去了。\n" +
"[格瑞？]\n" +
"格瑞示意让雷狮过来。\n" +
"雷狮看见的是三个小斯巴达的其中一个，看着格瑞对床安迷修的武器正发抖。\n", "第五章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Button6.Visible = false;
            MessageBox.Show("雷狮死了，死在学院后山，也就是紫堂幻出事的地方。\n" +
"没人知道雷狮来这里干什么，只有一旁的卡米尔若有所思。\n" +
"而前来凑热闹的凯莉在看了看雷狮周围后笑了。\n" +
"[不需要解释什么吗？]\n" +
"一旁的安莉洁给了凯莉一样东西，那个看上去像是一条领带。\n" +
"[最后的骑士……]\n" +
        "[安迷修？]\n", "第六章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Button7.Visible = false;
            MessageBox.Show("安迷修的罪名算是坐定了。\n" +
"对于雷狮的死亡安迷修什么也没说，就像是默认是他干的那样。\n" +
"而凯莉则自请去看管安迷修。\n" +
"可是不到一天，凯莉和安迷修的尸体都被人发现了。\n" +
"凯莉和安迷修身上都有被利器明显贯穿的痕迹。\n" +
"不同的是凯莉的伤口处没有血，反而有些焦黑的痕迹。\n" +
"[是我干的。]\n" +
"艾比很干脆地承认了。\n" +
"[我看不惯那个没马骑士，就杀了他，至于星月魔女，那和我可没有关系。]\n" +
        "一旁的埃米正拉着艾比示意她别乱讲话。\n", "第七章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Button8.Visible = false;
            MessageBox.Show("卡米尔和格瑞吵起来了。\n" +
"临走前卡米尔甚至不顾任何人的面子，把门甩上了。\n" +
"而格瑞的脸上还是那副淡定的表情。\n" +
"是夜，有人来格瑞宿舍了。\n" +
"[我不认为是安迷修干的，只是为什么他会去紫堂幻那里？]\n" +
"[现在不方便说，我可能明天就会死了，我得先去赴约了。]\n" +
"[？]\n" +
"[正好可以嫁祸给你，所以，这个藏好。]\n" +
"格瑞给了来人一张纸条。\n" +
"[去找莱娜。]\n", "第八章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button9.Visible = false;
            MessageBox.Show("格瑞和嘉德罗斯的尸体被发现了。\n" +
"发现的地点是他俩一直打架的地方。\n" +
"据雷德和祖玛说，嘉德罗斯发现了断掉的染了血的烈斩。\n" +
"就什么都没说就去找格瑞了。\n" +
"[19 15 19]\n" +
"这是写在烈斩上的字。\n" +
"[嘿你们看见帕洛斯了吗？]\n" +
        "状况外的佩利这么说道。\n" +
"[没有。]\n" +
        "[怎么可能，这里确实有帕洛斯的气味啊。]\n", "第九章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Button10.Visible = false;
            MessageBox.Show("莱娜的尸体在她的宿舍里，大概是晚上死的。\n" +
"卡米尔发现的。\n" +
"发现的时候莱娜很虚弱，话语模糊不清。\n" +
"[救……]\n" +
"救谁？\n" +
"卡米尔不知道，他只是看了看手中的东西。\n" +
"[……]\n", "第十章", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Button11.Visible = false;
            MessageBox.Show("[你给金那小子的东西我还没找到哦。]\n" +
"[真没想到你居然那么好心。]\n" +
"[话说觊觎那东西的狐狸也从笼子里逃出去了哦。]\n" +
"……\n" +
"[没事， 都死了。]\n" +
"[你的伤怎么样？]\n" +
"[被贯穿了非实体而已， 我身后那位就不好了。]\n", "终章(第十一章)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("以下是本次游戏的提示:\n" +
"1.紫堂幻有在隐瞒什么东西\n" +
"2.小斯巴达有一个还活着\n" +
"3.非实体可以被贯穿\n" +
"4.凶手有的死了有的活着 不止一个\n" +
"5.格瑞知道事情的大部分真相。而卡卡也快分析出来了\n" +
"6.确定无嫌疑的只有卡卡，莱娜\n" +
"7.安迷修离开格瑞宿舍后去了学院后山 雷狮也是哦.\n" +
"8.cp安艾 玛德.\n" +
"9.黑金不存在，但……\n" +
"提示按钮将不会隐藏，您可以查看多次。\n", "游戏提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？\n" + "游戏进度将不会保存。\n", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void 答案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要查看答案吗？\n", "查看答案", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                System.Diagnostics.Process.Start("notepad.exe", "Answer.txt");
        }

        private void 关于AOTU推理游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("软件作者:雷翎 Lrtray.（半次元:雷翎） 文案作者:半青不白（半次元:我似鸽莫得感情的刺客）\n" +
                            "Created By Visual Studio 2017.(C# .Net Framework 4.5)\n", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 更新日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "Updates For Alpha.txt");
        }

        private void 关于CBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# Branch是我尝试用C#语言来重新编写的这个推理小游戏。由于初学原因，也参考了不少教程与帖子，请多多理解啦QWQ\n" +
                            "V1.0:初版 Core版本 V1.5，由VB语言移植到C#语言。已知Bug:在用户的最终结果为部分正确时，不限时对话框。\n", "关于 C# Branch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎来到AOTU推理游戏！\n"+
"你将要扮演侦探，揪出这场案件的所有杀人犯！准备好！单击确定开始。\n" , "欢迎", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

