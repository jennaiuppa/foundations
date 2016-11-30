// File: tv.cs

class Television
{
    private int channel = 0; //field
    private int volume = 0; //field 
    private bool isOn = false; //field

    public bool IsOn() //method
    {
        return isOn;//status of tv 
    } 
    public void TurnOn()
    {
        isOn = true; //the tv on
        // do the code to turn the tv on
    }
    public void TurnOff()
    {
        isOn = false; //turn the tv off
        // do the code to turn the tv off
    }

    public int CurrentVolume()
    {
        return volume;
    } //tells the currennt volume as an int
    public void IncreaseVolume()
    {
        if (volume < 100) //limit volume to 100, becuase it is private - user doesnt know what the limit is, but can change the volume.  DATA HIDING - keeping volume private 
        {
            volume = volume + 1;
            // do the code to increase the volume
        }
    } //increases the volume 
    public void DecreaseVolume()
    {
        if (volume > 0)
        {
            volume = volume - 1;
            // do the code to decrease the volume
        }
    } //decreases the volume

    public int CurrentChannel()
    {
        return channel;
    } //tells what channel it is currntly on
    public void ChangeChannel(int Channel)
    {
        if (Channel > 0 && Channel < 50) //data hiding and control 
        {
            channel = Channel;
            // do the code to change the
            // channel on the tv
        }
    } //changes to specific channel 
}

class TestTV
{
    static void Main() //compiler starts
    {
        Television tv = new Television(); //instantiation starts 

        if (tv.IsOn() == false) //is the tv on?
        {
            tv.TurnOn(); //turn on the tv
        }

        tv.ChangeChannel(3); //change channel to channel 3

        tv.IncreaseVolume(98); //turn up the volume
        tv.IncreaseVolume();
        tv.IncreaseVolume();
        tv.IncreaseVolume();

        tv.TurnOff(); //turn off tv
    }
}