using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Binary
    {
        Binary right;
        Binary left;
        int data;
        public Binary(int n_data)
        {
            left = null;
            right = null;
            this.data = n_data;
        }
        public int minValue()
        {
            if (left != null)
            {
                return right.minValue();
            }
            else
            {
                return data;
            }
        }
        public int maxValue()
        {
            if (right != null)
            {
                return right.maxValue();
            }
            else
            {
                return data;
            }
        }
        public void Add(int n_data)
        {
            if (n_data > data)
            {
                if (right != null)
                {
                    right.Add(n_data);
                    return;
                }
                else
                {
                    right = new Binary(n_data);
                }
            }
            else if (n_data < data)
            {
                if (left != null)
                {
                    left.Add(n_data);
                    return;
                }
                else
                {
                    left = new Binary(n_data);
                }
            }
            else
            {
                Console.WriteLine("n_data not equal to data in Binary Search Tree");
            }
        }
        public void Delete(int n_data, Binary parent = null)
        {
            if (n_data > data)
            {
                if (right != null)
                {
                    right.Delete(n_data, this);
                    return;
                }
                else
                {
                    Console.WriteLine("Error / no data already on the right");
                }
            }
            else if (n_data < data)
            {
                if (left != null)
                {
                    left.Delete(n_data, this);
                    return;
                }
            }
            else
            {
                if (right == null & left == null)
                {
                    if (parent.right == this)
                    {
                        parent.left = null;
                    }
                    else
                    {
                        parent.right = null;
                    }
                }
                else if (right != null & left != null)
                {
                    data = right.minValue();
                    right.Delete(data, this);
                    return;
                }
                else if (right != null)
                {
                    if (parent.left == this)
                    {
                        parent.left = right;
                    }
                    else
                    {
                        parent.right = right;
                    }
                }
                else if (left != null)
                {
                    if (parent.right == this)
                    {
                        parent.right = left;
                    }
                    else
                    {
                        parent.left = left;
                    }
                }
            }
        }
        public Binary Search(int n_data)
        {
            if (n_data < data)
            {
                if (left != null)
                {
                    return left.Search(n_data);
                }
                else
                {
                    return null;
                }
            }
            else if (n_data > data)
            {
                if (right != null)
                {
                    return right.Search(n_data);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return this;
            }
        }
    }
}
