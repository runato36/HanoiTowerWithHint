using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TimeSpan time; // creat time count variable
        PictureBox[] disks; // creat disks array
        int moveCount; // creat move counter variable

        // creat stack pictureBox (cuz each elemete is a pictureBox )
        // firstClickedDisks and secondClickedDisks re basicly the first disk on the Rod now, use for compare 2 value to know that we can move it or cannot
        Stack<PictureBox> disksA, disksB, disksC, firstClickedDisks, secondClickedDisks;
        const int FirstY = 487, DiskHeight = 20, DistanceXFromRodToDisk = 11; // disk weight height and distance info


        public Form1()
        {
            InitializeComponent();
            disks = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8 }; // value for disks 
            picBoxRodA.Tag = disksA = new Stack<PictureBox>(); // creat disks at Rod A belong to stack pictureBox and set Tag for Rod A
            picBoxRodB.Tag = disksB = new Stack<PictureBox>(); // creat disks at Rod B belong to stack pictureBox and set Tag for Rod B
            picBoxRodC.Tag = disksC = new Stack<PictureBox>(); // creat disks at Rod C belong to stack pictureBox and set Tag for Rod C
        }

        static int movecount = 0; // count Algorithmus step

        // this function is use for solve 1 step
        static public void Solve2DiscsTOH(Stack<int> source, Stack<int> temp, Stack<int> dest) 
        {
            temp.Push(source.Pop());
            movecount++;
            PrintStacks();
            dest.Push(source.Pop());
            movecount++;
            PrintStacks();
            dest.Push(temp.Pop());
            movecount++;
            PrintStacks();
        }

        // solve 
        static public bool SolveTOH(int nDiscs, Stack<int> source, Stack<int> temp, Stack<int> dest)
        {
            if (nDiscs <= 4)
            {
                if ((nDiscs % 2) == 0)
                {
                    Solve2DiscsTOH(source, temp, dest);
                    nDiscs = nDiscs - 1;
                    if (nDiscs == 1)
                        return true;

                    temp.Push(source.Pop());
                    movecount++;
                    PrintStacks();
                    //new source is dest, new temp is source, new dest is temp;
                    Solve2DiscsTOH(dest, source, temp);
                    dest.Push(source.Pop());
                    movecount++;
                    PrintStacks();
                    //new source is temp, new temp is source, new dest is dest;
                    SolveTOH(nDiscs, temp, source, dest);
                }
                else
                {
                    if (nDiscs == 1)
                        return false;
                    Solve2DiscsTOH(source, dest, temp);
                    nDiscs = nDiscs - 1;
                    dest.Push(source.Pop());
                    
                    movecount++;
                    PrintStacks();
                    Solve2DiscsTOH(temp, source, dest);
                }
                return true;
            }
            else if (nDiscs >= 5)
            {
                SolveTOH(nDiscs - 2, source, temp, dest);
                temp.Push(source.Pop());
                movecount++;
                PrintStacks();
                SolveTOH(nDiscs - 2, dest, source, temp);
                dest.Push(source.Pop());
                movecount++;
                PrintStacks();
                SolveTOH(nDiscs - 1, temp, source, dest);
            }
            return true;
        }

        static public Stack<int> A = new Stack<int>();
        static public Stack<int> B = new Stack<int>();
        static public Stack<int> C = new Stack<int>();

        // class move info include data of the Move
        public class MoveInfo
        {
            public string src;
            public string dest;
            public int number;
         
            // construction
            public MoveInfo(string s, string d, int n)
            {
                src = s;
                dest = d;
                number = n;
            }
        }

        // class for current move in array form 
        public class stepMove
        {
            public int[] A;
            public int[] B;
            public int[] C;

            // construction
            public stepMove(Stack<int> a, Stack<int> b, Stack<int> c)
            {
                A = a.ToArray();
                B = b.ToArray();
                C = c.ToArray();
            }
        }
        // List of algorithmus move info
        static public List<MoveInfo> algorithm_steps = new List<MoveInfo>();

        // List of a algorithmus situation
        static public List<stepMove> step_Current = new List<stepMove>();

        static int countA = 0;
        static int countB = 0;
        static int countC = 0;

        // Capture situation und Moved 
        static public void PrintStacks()
        {
            // capture situation
            step_Current.Add(new stepMove(A, B, C));
            
            // check if any disk was moved
            if (countA != A.Count ||
                countB != B.Count ||
                countC != C.Count)
            {
                int diffA = A.Count - countA;
                int diffB = B.Count - countB;
                int diffC = C.Count - countC;
               
                // A was moved
                if (diffA == 1)
                {
                    if (diffB == -1) // to B
                        algorithm_steps.Add(new MoveInfo("B", "A", A.Peek()));
                    else   // to C
                        algorithm_steps.Add(new MoveInfo("C", "A", A.Peek()));
                }
                else if (diffB == 1) // B was moved
                {
                    if (diffA == -1) // to A
                        algorithm_steps.Add(new MoveInfo("A", "B", B.Peek()));
                    else // to B
                        algorithm_steps.Add(new MoveInfo("C", "B", B.Peek()));
                }
                else //if (diffC == 1) C was moved
                {
                    if (diffA == -1) // to A
                        algorithm_steps.Add(new MoveInfo("A", "C", C.Peek()));
                    else // to B
                        algorithm_steps.Add(new MoveInfo("B", "C", C.Peek()));
                }
              
                // reset
                countA = A.Count;
                countB = B.Count;
                countC = C.Count;
                Console.WriteLine();
            }
        }

        // click Rod (abstrakt)
        private void picRod_Click(object sender, EventArgs e)
        {
            if (nudLevel.Enabled) return; // not playing
            PictureBox clickedRod = (PictureBox)sender; // set clickedRod elemente (its the sender now when we click it)

            Stack<PictureBox> diskOfClickedRod = (Stack<PictureBox>)clickedRod.Tag; // creat disk of clicked Rod to know which disk will moved

            if (firstClickedDisks == null) // the first click time (no value is set)
            {
                if (diskOfClickedRod.Count == 0) return; // if the rod has no disk -> end

                firstClickedDisks = diskOfClickedRod; // set value of the disk 
                clickedRod.BorderStyle = BorderStyle.FixedSingle; // show the boder to know that this Rod is choosed
            }
            else if (secondClickedDisks == null)
            {
                if (diskOfClickedRod == firstClickedDisks) // if click twice on same Rod -> its mean unchoose this rod
                {
                    firstClickedDisks = null; // reset click value
                    clickedRod.BorderStyle = BorderStyle.None; // remove border
                    return;
                }
                secondClickedDisks = diskOfClickedRod;
                processMovingDisk(clickedRod); // call Moving process to move disk for firstClickedDisk to secondClickedDisk
            }
        }

        // to prevent player missclicked when player clicked the picturebox of Disk not the Rod
        private void pic_Click(object sender, EventArgs e)
        {
            // just change the sender.
            PictureBox clickedDisk = (PictureBox)sender;
            if (disksA.Contains(clickedDisk))
                picRod_Click(picBoxRodA, new EventArgs()); // call picRod_Click for Rod A (to redirect)
            else if (disksB.Contains(clickedDisk))
                picRod_Click(picBoxRodB, new EventArgs()); // call picRod_Click for Rod B (to redirect)
            else if (disksC.Contains(clickedDisk))
                picRod_Click(picBoxRodC, new EventArgs()); // call picRod_Click for Rod C (to redirect)
        }

        // Hint
        private void btmHint_Click(object sender, EventArgs e)
        {
            // get info
            int a = disksA.Count();
            int b = disksB.Count();
            int c = disksC.Count();
            int max = 0;

            int maxA = getMax(disksA);
            int maxB = getMax(disksB);
            int maxC = getMax(disksC);

         
            // get current Situation
            Stack<int> currentA = new Stack<int>();
            Stack<int> currentB = new Stack<int>();
            Stack<int> currentC = new Stack<int>();

            currentA = getTagValue(disksA);
            currentA = reserveStack(currentA);

            currentB = getTagValue(disksB);
            currentB = reserveStack(currentB);
            
            currentC = getTagValue(disksC);
            currentC = reserveStack(currentC);

            // setter current
            stepMove current = new stepMove(currentA, currentB, currentC);

            bool isMove = false; // check if moved or not
            
            // read all the step 
            for (int i = 0; i < step_Current.Count; i++)
            {         
                // compare current situation with algo step
                bool checkA = Enumerable.SequenceEqual(step_Current[i].A, current.A);
                bool checkB = Enumerable.SequenceEqual(step_Current[i].B, current.B);
                bool checkC = Enumerable.SequenceEqual(step_Current[i].C, current.C);

                if (checkA == true && checkB == true && checkC == true)
                {
                    // move follow the algo
                    MoveInfo info = algorithm_steps[i];

                    if (info.src == "A")
                    {
                        if (info.dest == "B")
                        {
                            MessageBox.Show("move disk form Rod A to B");
                            moveDiskAuto(disksA, disksB);
                        }
                        else
                        {
                            MessageBox.Show("move disk form Rod A to C");
                            moveDiskAuto(disksA, disksC);
                        }
                    }
                    else if (info.src == "B")
                    {
                        if (info.dest == "C")
                        {
                            MessageBox.Show("move disk form Rod B to C");
                            moveDiskAuto(disksB, disksC);
                        }
                        else
                        {
                            MessageBox.Show("move disk form Rod B to A");
                            moveDiskAuto(disksB, disksA);
                        }
                    }
                    else if (info.src == "C")
                    {
                        if (info.dest == "A")
                        {
                            MessageBox.Show("move disk form Rod C to A");
                            moveDiskAuto(disksC, disksA);
                        }
                        else
                        {
                            MessageBox.Show("move disk form Rod C to B");
                            moveDiskAuto(disksC, disksB);
                        }
                    }
                    isMove = true; // moved,-> right move -> skip false move check
                }
            }
            if (isMove == false) // false step -> go check
            {
                if ((int)nudLevel.Value % 2 == 0)
                {
                    if (maxB == maxC)
                    {
                        DialogResult hint = MessageBox.Show("Move the disk from A to B", "hint", MessageBoxButtons.RetryCancel);
                        if (hint == DialogResult.Retry)
                        {
                            btmPlay_Click(sender, e);
                        }
                    }
                    else if (maxB < maxC)
                    {
                        max = maxC;
                        if (max % 2 == 1)
                        {
                            DialogResult hint = MessageBox.Show("You made a wrong move!! \n" +
                                                                 "Should try to make disk " + max + "move to rod B\n" +
                                                                 "You can try again or countinue to solve", "Hint", MessageBoxButtons.RetryCancel);
                            if (hint == DialogResult.Retry)
                            {
                                btmPlay_Click(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("go on", "hint");
                        }
                    }
                    else
                    {
                        max = maxB;
                        if (max % 2 != 0)
                        {
                            MessageBox.Show("go on", "Hint");
                        }
                        else
                        {
                            DialogResult hint = MessageBox.Show("You made a wrong move!! \n" +
                                                                "Should try to make disk " + max + "move to rod C \n" +
                                                                "You can try again or countinue to solve", "Hint", MessageBoxButtons.RetryCancel);
                            if (hint == DialogResult.Retry)
                            {
                                btmPlay_Click(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    if (maxB == maxC)
                    {
                        DialogResult hint = MessageBox.Show("Move the disk from A to B", "hint", MessageBoxButtons.RetryCancel);
                        if (hint == DialogResult.Retry)
                        {
                            btmPlay_Click(sender, e);
                        }
                    }
                    else if (maxB < maxC)
                    {
                        max = maxC;
                        if (max % 2 == 0)
                        {
                            DialogResult hint = MessageBox.Show("You made a wrong move!! \n" +
                                                                 "Should try to make disk " + max + "move to rod B\n" +
                                                                 "You can try again or countinue to solve", "Hint", MessageBoxButtons.RetryCancel);
                            if (hint == DialogResult.Retry)
                            {
                                btmPlay_Click(sender, e);
                            }
                        }
                        else
                        {
                            MessageBox.Show("go on", "Hint");
                        }
                    }
                    else
                    {
                        max = maxB;
                        if (max % 2 == 0)
                        {
                            MessageBox.Show("go on", "Hint");
                        }
                        else
                        {
                            DialogResult hint = MessageBox.Show("You made a wrong move!! \n" +
                                                                "Should try to make disk " + max + "move to rod C \n" +
                                                                "You can try again or countinue to solve", "Hint", MessageBoxButtons.RetryCancel);
                            if (hint == DialogResult.Retry)
                            {
                                btmPlay_Click(sender, e);
                            }
                        }
                    }
                }
            }
            
        }

       
        //
        public Stack<int> getTagValue(Stack<PictureBox> A)
        {
            Stack<int> tagValue = new Stack<int>();
            foreach (PictureBox disk in A)
            {
                tagValue.Push(int.Parse(disk.Tag.ToString()));
            }
            return tagValue;
        }

        // get reserve Stack 
        public Stack<int> reserveStack(Stack<int> A)
        {
            Stack<int> reserveStack = new Stack<int>();
            while(A.Count != 0)
            {
                reserveStack.Push(A.Pop());
            }
            return reserveStack;
        }

        // get Max Disk from Rod
        private int getMax(Stack<PictureBox> disks)
        {
            int length = disks.Count;
            int max = 0;
            
            Stack<PictureBox> diskTemp = new Stack<PictureBox>(disks.ToArray());

            foreach (PictureBox disk in disks)
            {
                max = int.Parse(disk.Tag.ToString());
            }
            
           
            return max;
        }

        // Move disk Auto Animation
        public void moveDiskAuto(Stack<PictureBox> rodSrc, Stack<PictureBox> rodDes)
        {
            int x = 0, y = 0;
            PictureBox DiskPop = new PictureBox();
            Point pntScr = new Point(x, y);

            DiskPop = rodSrc.Pop();
            pntScr = DiskPop.Location;
            x = pntScr.X;
            y = pntScr.Y;
            Application.DoEvents();

            for (; y > 250; y--)
            {
                DiskPop.Visible = false;
                DiskPop.Location = new Point(x, y);
                DiskPop.Visible = true;
                Application.DoEvents();
                
            }

            int xPeek = 0, yPeek = 0;
            PictureBox tempPeek = new PictureBox();
            if (rodDes.Count != 0)
            {
                tempPeek = rodDes.Peek();
                xPeek = tempPeek.Location.X;
                yPeek = tempPeek.Location.Y - 20;
            }
            else
            {
                yPeek = FirstY;
                if (rodDes == disksA)
                    xPeek = 284;
                else
                    if (rodDes == disksB)
                    xPeek = 526;
                else
                    xPeek = 768;
            }

            //MessageBox.Show("x=" + x + ", xPeek=" + xPeek);
            if (xPeek > x)
                for (; x <= xPeek; x++)
                {
                    DiskPop.Visible = false;
                    DiskPop.Location = new Point(x, y);
                    DiskPop.Visible = true;
                    Application.DoEvents();
                }
            else
                for (; x >= xPeek; x--)
                {
                    DiskPop.Visible = false;
                    DiskPop.Location = new Point(x, y);
                    DiskPop.Visible = true;
                    Application.DoEvents();
                }

       
            for (; y <= yPeek; y++)
            {
                DiskPop.Visible = false;
                DiskPop.Location = new Point(x, y);
                DiskPop.Visible = true;
                Application.DoEvents();
           
            }
            //MessageBox.Show("x=" + DiskPop.Location.X + ", y=" + DiskPop.Location.Y);
            rodDes.Push(DiskPop);

            if ((disksC.Count == nudLevel.Value) || (disksB.Count == nudLevel.Value)) // check the final result
            {
                btmGiveUp.PerformClick(); // use GiveUp buttom like a reset buttom
                MessageBox.Show("Congrat"); // grat the player
            }
        }



        // moving disk (PROCESS)
        private void processMovingDisk(PictureBox clickedRod)
        {
            if (secondClickedDisks.Count == 0) // if theres no disk in secondClicked Rod
                moveDisk(new Point(clickedRod.Location.X + DistanceXFromRodToDisk, FirstY)); // move disk
            else
            {
                PictureBox firstTopDisk = firstClickedDisks.Peek(); // get value from Clicked Rod  
                PictureBox secondTopDisk = secondClickedDisks.Peek(); // get value from Clicked Rod
                if (int.Parse(firstTopDisk.Tag.ToString()) < int.Parse(secondTopDisk.Tag.ToString())) // compare value of 2 disks
                    moveDisk(new Point(secondTopDisk.Location.X, secondTopDisk.Location.Y - DiskHeight)); // move disk
                else
                    secondClickedDisks = null; // Not move
            }
        }

        // move disk function
        private void moveDisk(Point point)
        {
            PictureBox firstTopDisk = firstClickedDisks.Pop(); // get the Top picturBox of firstClickedRod
            firstTopDisk.Location = point; // set location
            secondClickedDisks.Push(firstTopDisk); // move to second Clicked Rod
            ++moveCount; // move count + 1
            lblMove.Text = string.Format("Move : {0}", moveCount); // change move count label
            firstClickedDisks = secondClickedDisks = null; // reset firstclick and second click to make another move 
            picBoxRodA.BorderStyle = picBoxRodB.BorderStyle = picBoxRodC.BorderStyle = BorderStyle.None; // clear border 

            if ((disksC.Count == nudLevel.Value) || (disksB.Count == nudLevel.Value)) // check the final result
            {
                btmGiveUp.PerformClick(); // use GiveUp buttom like a reset buttom
                MessageBox.Show("Congrat"); // grat the player
            }
        }

        private void btmRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to play :\n- ... //write rule here",
                "Rule :", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrCountTime_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1)); // Initialisierung time 
            lblTime.Text = string.Format("Time : {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds); // label 
        }

        private void btmGiveUp_Click(object sender, EventArgs e)
        {
            tmrCountTime.Stop(); // stop time count
            nudLevel.Enabled = true; // level choose enable
            btmGiveUp.Enabled = false; // disable GiveUp btm
            btmHint.Enabled = false;
            btmPlay.Text = "Play"; // enable Play btm
        }

        public void btmPlay_Click(object sender, EventArgs e)
        {
            //reset
            tmrCountTime.Stop(); // stop time counter
            // hide disk
            foreach (PictureBox disk in disks) 
            {
                disk.Visible = false;
            }
            // end hide disk

            time = new TimeSpan(0); // new time counter
            moveCount = 0; // new move counter = 0
            lblTime.Text = "Time : 00:00:00"; // label = 00 : 00 : 00
            lblMove.Text = "Move : 0"; // label count = 0 

            // clear disk at all the rod
            disksA.Clear(); 
            disksB.Clear();
            disksC.Clear();
            // end clear

            // Clear all the Boderstyle of all the Rod to prepare for click rod button
            picBoxRodA.BorderStyle = picBoxRodB.BorderStyle = picBoxRodC.BorderStyle = BorderStyle.None; 

            firstClickedDisks = secondClickedDisks = null; // reset the value in this
            // end reset

            // initialize
            nudLevel.Enabled = false; // disable level buttom
            btmGiveUp.Enabled = true; // enable GiveUp buttom
            btmHint.Enabled = true;
            btmPlay.Text = "Replay"; // change PlayButtom into Replay Buttom

            int x = picBoxRodA.Location.X + DistanceXFromRodToDisk, y = FirstY; // set location for the first Rod to make it like a cordinator
            
            for (int i = (int)nudLevel.Value - 1; i >= 0; --i, y -= DiskHeight) // show disk on Rod 
            {
                disks[i].Location = new Point(x,y); // set Location for disk
                disks[i].Visible = true; // visible disk
                disksA.Push(disks[i]); // push it into stack rod A
            }
            tmrCountTime.Start(); // start time count
            algorithm_steps.Clear(); // clear cache
            step_Current.Clear(); // clear cache

            // get input for solve function (stack<int> instead of stack<PictureBox>)
            for (int i = (int)nudLevel.Value; i >= 1; i--)
                A.Push(i);

            // get Current situation
            countA = A.Count;
            countB = B.Count;
            countC = C.Count;

            // capture situation
            PrintStacks();
            
            // Solve algorithmus
            SolveTOH((int)nudLevel.Value, A, B, C);
        

        }
    }
    
}
