using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:  trying to dequeue from an empty queue
    // Expected Result: should throw an exception
    // Defect(s) Found: exception thrown:the queue is empty
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }

        catch (InvalidOperationException exception)
        {
            Assert.AreEqual("The queue is empty.", exception.Message);
        }
        
    }

    [TestMethod]
    // Scenario: add and remove a single item from the queue
    // Expected Result: Gorata
    // Defect(s) Found: none. a single item is correctly returned when dequeued
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Gorata",5);
        var results = priorityQueue.Dequeue();
       
    }

    [TestMethod]
    // Scenario: highest priority item was selected first
    // Expected Result: high
    // Defect(s) Found: none: the item with the highest priority is removed first
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low",1);
        priorityQueue.Enqueue("Medium",5);
        priorityQueue.Enqueue("High",10);

        var results = priorityQueue.Dequeue();
        
    }

    [TestMethod]
    // Scenario: if there are multiple items with the same priority value it should be first in first out {A B C}
    // Expected Result: A B C
    // Defect(s) Found: items with the same priority were dequeued in the reverse order instead of first-in first-out
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",1);
        priorityQueue.Enqueue("B",1);
        priorityQueue.Enqueue("C",1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: if there are multiple items with different priority value it should go from high to low
    // Expected Result: B D A C
    // Defect(s) Found: when multiple items shared the same priority the most recently added item was removed first instead of the earliest item
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",4);
        priorityQueue.Enqueue("B",10);
        priorityQueue.Enqueue("C",2);
        priorityQueue.Enqueue("D",10);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: check that items are removed
    // Expected Result: A, InvalidOperationException
    // Defect(s) Found: none. items are removed from the queuw after being dequeued
    public void TestPriorityQueue_6()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",10);
    
        var removedItem = priorityQueue.Dequeue();
        Assert.AreEqual("A", removedItem);

    }

    [TestMethod]
    // Scenario: last item has the highest priority: A,1 B,2 C,9
    // Expected Result: C
    // Defect(s) Found: none. the highest priority item is correctly selected even whe added last
    public void TestPriorityQueue_7()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A",1);
        priorityQueue.Enqueue("B",2);
        priorityQueue.Enqueue("C",9);

        Console.WriteLine(priorityQueue.Dequeue()); 
    }
}