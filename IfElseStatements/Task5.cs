namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething1(bool b1, bool b2, bool b3, bool b4)
        {
            if (b1)
            {
                if (!b2)
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (!b2)
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            return 11;
                        }
                        else
                        {
                            return 10;
                        }
                    }
                    else
                    {
                        if (!b4)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
                else
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            return 8;
                        }
                        else
                        {
                            return 9;
                        }
                    }
                    else
                    {
                        if (!b4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        public static int DoSomething2(bool b1, bool b2, bool b3, bool b4)
        {
            if (b1 && b2)
            {
                return 1;
            }
            else if (b1)
            {
                if (b3)
                {
                    return 2;
                }
                else
                {
                    if (b4)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                if (!b2)
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            return 11;
                        }
                        else
                        {
                            return 10;
                        }
                    }
                    else
                    {
                        if (!b4)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
                else
                {
                    if (!b3)
                    {
                        if (!b4)
                        {
                            return 8;
                        }
                        else
                        {
                            return 9;
                        }
                    }
                    else
                    {
                        if (!b4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
