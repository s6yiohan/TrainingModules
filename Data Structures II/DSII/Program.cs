using System;
using System.Numerics;

public class SearchAlgo{

    static IDictionary<int, List<int>> tree = new Dictionary<int, List<int>>();


    static HashSet<int> itemCovered = new HashSet<int>();
    static Queue<int>  queue = new Queue<int>();


    public static void Main(){
        tree[1] = new List<int> { 2, 3, 4 };
        tree[2] = new List<int> { 5 };
        tree[3] = new List<int> { 6, 7 };
        tree[4] = new List<int> { 8 };
        tree[5] = new List<int> { 9 };
        tree[6] = new List<int> { 10 };
        
        
        StartQueue();
    }


    static void StartQueue(){
        queue.Enqueue(tree.ElementAt(0).Key);

        while(queue.Count > 0){
            var element = queue.Dequeue(); 
            if(itemCovered.Contains((int) element)){
                continue;
            } 
            else{
                itemCovered.Add((int)element);
            }

            Console.WriteLine(element);

            List<int> neighbors = new List<int>();
            tree.TryGetValue(Convert.ToInt32(element), out neighbors);
            if (neighbors == null)
                    continue;
            foreach (var item1 in neighbors)
            {
                queue.Enqueue(item1);
            }
    
        }
    }
}