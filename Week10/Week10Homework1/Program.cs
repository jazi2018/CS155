namespace Week10Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duelist aaron = new Duelist("Aaron", 1.0 / 3.0);
            Duelist bob = new Duelist("Bob", 0.5);
            Duelist charlie = new Duelist("Charlie", 0.995);
            Duelist[] turn_order = { aaron, bob, charlie };
            int iterations = 10000;
            bool first_shot_miss = true;

            //string winner = SimDuel(turn_order);
            //Console.WriteLine("Winner of duel is: {0}", winner);
            SimMultipleDuels(turn_order, iterations, first_shot_miss);
        }

        static void SimMultipleDuels(Duelist[] turn_order, int iterations, bool first_shot_miss)
        {
            //each index correlates to a different duelist, accomidating for varying lengths
            int[] win_count = new int[turn_order.Length];
            for (int i = 0; i < iterations; i++)
            {
                string winner = SimDuel(turn_order, first_shot_miss);
                //find index of who won; increment win_count accordingly
                for (int j = 0; j < turn_order.Length; j++)
                {
                    if (winner.Equals(turn_order[j].Name))
                    {
                        win_count[j]++;
                    }
                }
            }
            //report results at the end
            Console.WriteLine("Results after {0} iterations:", iterations);
            for (int i = 0; i < turn_order.Length; i++)
            {
                double percentage = (win_count[i] / (double)iterations) * 100.0;
                Console.WriteLine("{0}: {1} / {2} duels = {3:.00}%", turn_order[i].Name,
                    win_count[i], iterations, percentage);
            }
        }

        //returns winner's name as a string
        static string SimDuel(Duelist[] turn_order, bool first_shot_miss)
        {
            //Console.WriteLine("SimDuel function entered");
            int alive_ct = turn_order.Length;
            int idx_turn = 0;
            //skip aarons first turn if missing first shot
            if (first_shot_miss)
            {
                idx_turn = 1;
            }
            //strategy is shoot most accurate shooter still alive
            while (alive_ct > 1)
            {
                if (!turn_order[idx_turn].IsAlive)
                {
                    idx_turn++;
                    if (idx_turn >= turn_order.Length)
                    {
                        idx_turn = 0;
                    }
                    continue;
                }

                //generate target
                int target_index = 0;
                double highest_accuracy = 0;
                for (int i = 0; i < turn_order.Length; i++)
                {

                    //if current iteration would access duelist whos turn it is, skip the iteration
                    if (i == idx_turn)
                    {
                        continue;
                    }

                    //if alive and has greater accuracy than previous iteration, update target
                    if (turn_order[i].IsAlive && turn_order[i].Accuracy > highest_accuracy)
                    {
                        target_index = i;
                        //Console.WriteLine("New target_index = {0}", target_index);
                        highest_accuracy = turn_order[i].Accuracy;
                        //Console.WriteLine("Target changed to: {0}", turn_order[i].Name);
                    }
                }

                //shoot target
                turn_order[idx_turn].ShootAtTarget(turn_order[target_index]);
                if (!turn_order[target_index].IsAlive)
                {
                    alive_ct--;
                }

                if (alive_ct > 1)
                {
                    idx_turn++;
                    //wrap back around to start of array
                    if (idx_turn >= turn_order.Length)
                    {
                        idx_turn = 0;
                    }
                }
            }
            //reset the duelists
            for (int i = 0; i < turn_order.Length; i++)
            {
                turn_order[i].Reset();
            }
            //returns whoever fired the last shot
            return turn_order[idx_turn].Name;
        }
    }
}
