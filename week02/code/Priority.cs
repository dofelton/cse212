public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: There are three bills to be paid. bills 1 and 2 are of equal priority but bill 3 must be paid first
        // Expected Result: Bill3
        Console.WriteLine("Test 1");
        var tasks = new PriorityQueue();
        tasks.Enqueue("Bill1", 1);
        tasks.Enqueue("Bill2", 1);
        tasks.Enqueue("Bill3", 2);
        Console.WriteLine(tasks.Dequeue());

        // Defect(s) Found: Method Dequeue was not removing items and was not iterateing through complete array

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Four bills must be paid, two of them are more important
        // Expected Result: Bill2
        Console.WriteLine("Test 2");
        var tasks2 = new PriorityQueue();
        tasks2.Enqueue("Bill1", 1);
        tasks2.Enqueue("Bill2", 2);
        tasks2.Enqueue("Bill3", 1);
        tasks2.Enqueue("Bill4", 2);

        Console.WriteLine(tasks2.Dequeue());
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}