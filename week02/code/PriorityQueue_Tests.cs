using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    /// <summary>
    /// Scenario: Enqueue a single item, then dequeue it.
    /// Expected Result: Item is returned correctly.
    /// Defect(s) Found: None.
    /// </summary>
    public void Test_SingleItem()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        Assert.AreEqual("A", pq.Dequeue());
    }

    [TestMethod]
    /// <summary>
    /// Scenario: Enqueue multiple items with different priorities.
    /// Expected Result: The item with the highest priority is returned.
    /// Defect(s) Found: None.
    /// </summary>
    public void Test_HighestPriorityWins()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Mid", 5);
        pq.Enqueue("High", 10);
        Assert.AreEqual("High", pq.Dequeue());
    }

    [TestMethod]
    /// <summary>
    /// Scenario: Enqueue multiple items with the same highest priority.
    /// Expected Result: The first of the high-priority items is returned (FIFO).
    /// Defect(s) Found: Original code used >=, returning later item instead.
    /// </summary>
    public void Test_FIFO_WhenSamePriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 5);
        pq.Enqueue("Second", 10);
        pq.Enqueue("Third", 10); // Same priority as Second

        // Should return "Second" because it was enqueued before "Third"
        Assert.AreEqual("Second", pq.Dequeue());
    }

    [TestMethod]
    /// <summary>
    /// Scenario: The last item in the queue has the highest priority.
    /// Expected Result: The last item is still dequeued correctly.
    /// Defect(s) Found: Original code skipped checking last item (off-by-one bug).
    /// </summary>
    public void Test_LastItemHighestPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 9); // Last item, highest priority
        Assert.AreEqual("C", pq.Dequeue());
    }

    [TestMethod]
    /// <summary>
    /// Scenario: Dequeue from an empty queue.
    /// Expected Result: InvalidOperationException is thrown.
    /// Defect(s) Found: None.
    /// </summary>
    [ExpectedException(typeof(InvalidOperationException))]
    public void Test_EmptyQueueThrows()
    {
        var pq = new PriorityQueue();
        pq.Dequeue();
    }
}
