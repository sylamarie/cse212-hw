using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueueing an item with High priority and then Dequeuing.
    // Expected Result: The item with High priority should be dequeued first.
    // Defect(s) Found: The priority queue should correctly prioritize High priority items.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        // Enqueue items with different priorities
        priorityQueue.Enqueue("Medium Priority", 2);
        priorityQueue.Enqueue("High Priority", 1);
        
        // Dequeue and check if the correct item comes out first
        var dequeuedItem = priorityQueue.Dequeue();
        
        // The expected result is "High Priority" because it has a higher priority
        Assert.AreEqual("High Priority", dequeuedItem);
    }

    [TestMethod]
    // Scenario: Trying to dequeue from an empty priority queue.
    // Expected Result: The exception should indicate that the queue is empty.
    // Defect(s) Found: The exception message does not match the expected one.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        // Expecting the queue to be empty
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected exception not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            // The expected message should be "The queue is empty."
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    // Add more test cases as needed below.
}