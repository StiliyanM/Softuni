using System;

namespace _10.TheHeiganDance
{
    class Program
    {
        static double heiganHealth = 3000000;
        static double playerHealth = 18500;
        static char[][] chamber = new char[15][];
        static double plagueDamage = 3500;
        static double eruptionDamage = 6000;
        static bool isHeiganDead = false;
        static bool isPlayedDead = false;
        static int playerRow = 8;
        static int playerCol = 8;
        static int plagueRoundsCounter = -1;

        // P - plague Cloud, E - eruption
        static void Main(string[] args)
        {
            InitializeChamber(chamber);

            var damage = double.Parse(Console.ReadLine());

            string spellType = "";
            while (true)
            {
                var heiganAttack = Console.ReadLine().Split();

                heiganHealth -= damage;

                if(heiganHealth <= 0)
                {
                    isHeiganDead = true;
                    break;
                }

                spellType = heiganAttack[0];
                var row = int.Parse(heiganAttack[1]);
                var col = int.Parse(heiganAttack[2]);

                if(spellType == "Eruption")
                {
                    ApplyEruption(row, col);

                    if (isPlayerInDamagedArea())
                    {
                        TryToMovePlayer();

                        if (isPlayedDead)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    plagueRoundsCounter = 2;
                    ApplyCloud(row, col);

                    if (isPlayerInDamagedArea())
                    {
                        TryToMovePlayer();

                        if (isPlayedDead)
                        {
                            break;
                        }
                    }
                    else
                    {
                        plagueRoundsCounter--;
                    }
                }
            }

            if (isPlayerInDamagedArea())
            {
                spellType = "Plague Cloud";
                TryToMovePlayer();
            }


        }

        private static void TryToMovePlayer()
        {
            bool didPlayerMove = false;

            for (int i = 0; i < 1; i++)
            {
                //up
                if (playerRow - 1 >= 0)
                {
                    if (chamber[playerRow - 1][playerCol] == '\0')
                    {
                        playerRow -= 1;
                        didPlayerMove = true;
                        break;
                    }
                }
                //right
                if(playerCol + 1 < 14)
                {
                    if(chamber[playerRow][playerCol + 1] == '\0')
                    {
                        playerCol += 1;
                        didPlayerMove = true;
                        break;
                    }
                }
                //down
                if (playerRow + 1 < 14)
                {
                    if (chamber[playerRow + 1][playerCol] == '\0')
                    {
                        playerRow += 1;
                        didPlayerMove = true;
                        break;
                    }
                }
                //left
                if (playerCol -1 > 0)
                {
                    if (chamber[playerRow][playerCol - 1] == '\0')
                    {
                        playerCol -= 1;
                        didPlayerMove = true;
                        break;
                    }
                }
            }

            if (!didPlayerMove)
            {
                if(chamber[playerRow][playerCol] == 'e')
                {
                    playerHealth -= eruptionDamage;



                }
                else if(chamber[playerRow][playerCol] == 'p')
                {
                    playerHealth -= plagueDamage;
                    plagueRoundsCounter--;
                }
            }
        }

        private static bool isPlayerInDamagedArea()
        {
            if(chamber[playerRow][playerCol] != '\0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ApplyCloud(int row, int col)
        {
            var beginningRow = Math.Max(0, row - 1);
            var endingRow = Math.Min(14, row + 1);
            var beginingCol = Math.Max(0, col - 1);
            var endingCol = Math.Min(14, col + 1);

            for (int i = beginningRow; i <= endingRow; i++)
            {
                for (int j = beginingCol; j <= endingCol; j++)
                {
                    chamber[i][j] = 'p';
                }
            }

        }

        private static void ApplyEruption(int row, int col)
        {
            var beginningRow = Math.Max(0, row - 1);
            var endingRow = Math.Min(14, row + 1);
            var beginingCol = Math.Max(0, col - 1);
            var endingCol = Math.Min(14, col + 1);


            for (int i = beginningRow; i <= endingRow; i++)
            {
                for (int j = beginingCol; j <= endingCol; j++)
                {
                    chamber[i][j] = 'e';
                }
            }
        }

        private static void InitializeChamber(char[][] chamber)
        {
            for (int row = 0; row < chamber.Length; row++)
            {
                chamber[row] = new char[15];
            }

        }
    }
}
