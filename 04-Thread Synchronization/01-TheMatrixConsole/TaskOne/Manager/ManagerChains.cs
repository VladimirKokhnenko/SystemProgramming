//using System;
//using System.Collections.Generic;
//using System.Threading;
//using TaskOne.Interfeces;
//using TaskOne.ChainTypes;
//using TaskOne.Resource;

//namespace TaskOne.Manager
//{
//    public class ManagerChains
//    {
//        //public List<Pair<int, bool>> IsTheColumnEmpty { get; set; }

//        public ManagerChains()
//        {
//            //IsTheColumnEmpty = new List<Pair<int, bool>>();
//            //for (int i = 0; i < Console.WindowWidth; i++)
//            //{
//            //    IsTheColumnEmpty.Add(new Pair<int, bool>(i, true));
//            //}
//        }

//        //public void ChainAndFlowManagmend()
//        //{
//        //    //var t = new Tuple<int, int, int, int>(
//        //    //    GetCoordinate(),
//        //    //    _startRangeChar,
//        //    //    _finishRangeChar,
//        //    //    new Random().Next(_startRangeTime, _finishRangeTime + 1));

//        //    (new Thread((tuple) =>
//        //    {
//        //        Tuple<int, int, int, int> t = tuple as Tuple<int, int, int, int>;

//        //        IChains ch = new Chain(t.Item1, t.Item2, t.Item3, t.Item4);
//        //            ch.ShowChain();
//        //            IsTheColumnEmpty[ch.X].Value = true;
//        //    })
//        //    { IsBackground = true }).Start(t);
//        //}

//        //private IChains GetChains()
//        //{
//        //    int coor = GetCoordinate();

//        //    return new Chain(
//        //        coor, _startRangeChar,
//        //        _finishRangeChar,
//        //        new Random().Next(_startRangeTime, _finishRangeTime + 1));
//        //}

//        //private int GetCoordinate()
//        //{
//        //    var rand = new Random();
//        //    int n = rand.Next(0, Console.WindowWidth);
//        //    int count = 0;

//        //    while (true)
//        //    {
//        //        if (IsTheColumnEmpty[n].Value == true)
//        //        {
//        //            IsTheColumnEmpty[n].Value = false;
//        //            return n;
//        //        }
//        //        else
//        //        {
//        //            n = rand.Next(0, Console.WindowWidth + 1);
//        //        }

//        //        count++;
//        //        if (count == _countTries)
//        //        {
//        //            for (int i = 0; i < Console.WindowWidth; i++)
//        //            {
//        //                if (IsTheColumnEmpty[i].Value == true)
//        //                {
//        //                    IsTheColumnEmpty[i].Value = false;
//        //                    return i;
//        //                }
//        //            }

//        //            return Console.WindowWidth + 1;
//        //        }
//        //    }
//        //}
//    }
//}
