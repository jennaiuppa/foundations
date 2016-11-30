// Class Exercise No. 1
// Rewrite TV Class, use properties instead of methods

class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;

    public bool On
    {
        get
        {
            return isOn;  // do code here
        }
        set
        {
            isOn = value;
            if (isOn)
            {
                isOn = true; // do code here
            }
            else
            {
                isOn = false;// do the code to turn the tv OFF
            }
        }
    }

    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                volume = value;// do the code to change the volume
            }
        }
    }

    public int Channel
    {
        get
        {
            return channel; // do the code to return the channel
        }
        set
        {
            if (value > 0 && value < 50)
            {
                // do the code to change the
                // channel on the tv
                channel = value;

            }
        }
    }
}

class pex1
{
    static void Main()
    {
        Television tv = new Television();

        if (tv.On == false)
        {
            tv.On = true;
        }

        tv.Channel = 3;

        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.On = false;
    }
}