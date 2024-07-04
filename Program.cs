using Garage;

Zero fxs = new Zero()
{
    MainColor = "red"
};

Tesla models = new Tesla()
{
    MainColor = "grey"
};

Cessna mx410 = new Cessna()
{
    MainColor = "blue"
};

Ram r1500 = new Ram()
{
    MainColor = "black"
};

fxs.Drive();
fxs.Turn();
fxs.Stop();

models.Drive();
models.Turn();
models.Stop();

mx410.Drive();
mx410.Turn();
mx410.Stop();

r1500.Drive();
r1500.Turn();
r1500.Stop();