using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class BT
    {
        BTNode root;

        public BT()
        {
            root = null;
        }

        public void insert( int data )
        {
            BTNode node = new BTNode( data );
            if( root==null )
            {
                root = node;
            } else
            {
                BTNode temp = root;
                while( true )
                {
                    if (data > temp.getData() )
                    {
                        if (temp.right != null)
                            temp = temp.right;
                        else
                            break;
                    }
                    if (data <= temp.getData())
                    {
                        if (temp.left != null)
                            temp = temp.left;
                        else
                            break;
                    }
                }

                if (data > temp.getData())
                    temp.right = node;
                else
                    temp.left = node;
            }
        }

        public void preOrder()
        {
            preOrder(root);
        }

        public void preOrder( BTNode r )
        {
            if( r!=null )
            {
                Console.WriteLine(r.getData());
                preOrder(r.left);
                preOrder(r.right);
            }
        }

        public void postOrder()
        {
            postOrder(root);
        }

        public void postOrder(BTNode r)
        {
            if (r != null)
            {
                preOrder(r.left);
                preOrder(r.right);
                Console.WriteLine(r.getData());
            }
        }

        public void inOrder()
        {
            inOrder(root);
        }

        public void inOrder(BTNode r)
        {
            if (r != null)
            {
                preOrder(r.left);
                Console.WriteLine(r.getData());
                preOrder(r.right);
            }
        }

        public Boolean isEmpty()
        {
            if( root==null )
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Boolean search( int data )
        {
            if( root!=null )
            {
                BTNode temp = root;
                while( true )
                {
                    if (temp.getData() == data)
                    {
                        return true;
                    }
                    else if( temp.getData()<data )
                    {
                        if (temp.right != null)
                            temp = temp.right;
                        else
                            break;
                    } else
                    {
                        if (temp.left != null)
                            temp = temp.left;
                        else
                            break;
                    }
                }
            }
            return false;
        }

        public void delete(int data)
        {
            BTNode temp = null;
            if (root != null)
            {
                temp = root;
                while (temp != null)
                {
                    if (temp.getData() == data)
                    {
                        break;
                    }
                    else if (temp.getData() < data)
                    {
                        if (temp.right != null)
                            temp = temp.right;
                        else
                        {
                            temp = null;
                            break;
                        }
                    }
                    else if (temp.getData() > data)
                    {
                        if (temp.left != null)
                            temp = temp.left;
                        else
                        {
                            temp = null;
                            break;
                        }
                    }
                } //END while LOOP

                if( temp==null)
                {
                    Console.WriteLine("Element you want to delete was not found!");
                }else
                {
                    Console.WriteLine("Lets Delete!");

                }



            }
        }


    }
}
