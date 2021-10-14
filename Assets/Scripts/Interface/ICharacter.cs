public interface ICharacter{
    bool isStop { get; set; }
    string Name { get; set; }
    float Speed { get; set; }
    void Idle();
    void Walk();
    void Dead();
};