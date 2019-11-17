﻿using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RogueSharp.MapCreation;
using RogueSharp.Random;

namespace RogueSharp.Test
{
   [TestClass]
   public class DungeonCreationStrategyTest
   {
      [TestMethod]
      public void Create_MapCreatedWithDungeonCreationStrategy_ExpectedMap()
      {
         DungeonCreationStrategy strategy = new DungeonCreationStrategy( 77, 29, new DotNetRandom( 11 ) );
         Dungeon dungeon = Map.Create( strategy );

         string expectedMap = @"#############################################################################
                                #.#.....#.......s...s...#...s.....s...........#.....#...#.......#.....#.....#
                                #.#.....s.#####.#...#...###s#.....#.#.#######.s.....s...#.#####.s.....#.#s###
                                #.#.....#.#...#.#...#...s...#.....#.#.#.....#.#.....#...#.#...#.#.....#.#...#
                                #.#####s#.#...###########...#.....#####.....#.#######...s.#...#.#########...#
                                #...#...#.#...s.......s.#...#.....#...s.....#.#.....#...#.#...#.........#...#
                                #.#.#...#.#...#.......#.#...#.....#...###s#####.....#####.#...s.#########...#
                                #.#.#...#.#...#.......#.s...#.....s...#.#.....#.....s...#.#...#.#.......#...#
                                #.#.#...#.#########################...#.#.....#.....#######...#.#.......##s##
                                #.#.#...#.#.....#.....#.....#.....#...#.#.....s.....s.....#...#.#.......#...#
                                ###s#####.#.....s.....#.....#####.s...#.#######.....#.....###s#.#.......s...#
                                #.....s.s.#.....#.....#.....#...#.#...#.......#.....#.....#...#.#.......#...#
                                #.....#.#####s#######s#.....#...########s##########s#######...#.#.......#...#
                                #.....#.#.......#.....#.....#...#.....#.....#.....#...#...#...#.#.......#...#
                                #########.......#.#.#.#.....#...#.....#.....#.....#...###s#...#.###s#########
                                #...#...#.......#.#.#.#.....s...#.....#.....#.....#...#...#...#.#...#.....s.#
                                #.#.#...#.......#####.#########s#.....#.....#s######s##...###s#.#...#.....#.#
                                #.#.#...#.......#...#...........#.....#.....#.........s...#...#.#...#.....#.#
                                #.#.#...####s####...#.#s#######.####s##.....s.#########...#.#.#.#...###s#s#.#
                                #.#.s...#.s...#.#...#.#.......#.#.....#.....#.s.......#...#.#.#.#...s...#.#.#
                                #.#.#####.#...s.##s####.......#.#.....#######s#.......###s###########...#.#.#
                                #.#.s...#.#...#.#.....#.......#.#.....#.#.....#.......#.#.......#...#...#.#.#
                                #####...#.#...#.#.....#.......#.#.....s.#.....#.......#.#.......#.#.#######.#
                                #...#...#.#...#.#.....#.......#.#.....#.#.....#.......#.#.......#.#...#...#.#
                                #...#...#.#...#.s.....#.......#.#.....#.#.....#.......#.#.......#.#.#.#...s.#
                                #...#...s.#...#.#.....#.......#.#.....#.#.....#.......#.#.......s.#.#.#...#.#
                                ###s###s#.#######.....#####s###.####s####s#############s#.......#.#.#.##s##.#
                                #.......#.......#.....#.......#.........................#.......#.#.#.....#.#
                                #############################################################################";

         Assert.AreEqual( RemoveWhiteSpace( expectedMap ), RemoveWhiteSpace( dungeon.ToString() ) );
      }

      private static string RemoveWhiteSpace( string source )
      {
         return Regex.Replace( source, @"\s+", string.Empty );
      }
   }
}
