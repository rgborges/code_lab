
namespace BinaryTree.Models;

public class TreeNode 
{
    private TreeNode? _left;
    private TreeNode? _right;
    private int _value;
    public TreeNode(int value)
    {
        _value = value;
    }
    /// <summary>
    /// Compare if the income value is grater than their leaves and store on TreeNode. Grater values are stored on the left while lower on the right.
    /// </summary>
    /// <param name="value">The income value</param>
    public void AddValue(int value)
    {
        if(value > _value)
        {
            //go to the right
            if(_left is null)
            {
                _left = new TreeNode(value);
            }
            else
            {
                _left.AddValue(value);
            }
        }
        else
        {
            if(_right is null)
            {
                _right = new TreeNode(value);
            }
            else
            {
                _right.AddValue(value);
            }
        }
    }
}
