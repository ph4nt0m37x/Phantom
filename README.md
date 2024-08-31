# Phantom
---
WinForms Project by: Marija Ilievska & Nikola Janev

## 1. Oпис на играта

Апликацијата што ја имплементираме е демо игра во стилот на визуелен роман (visual novel). Играта ја следи приказната на главниот лик како платеник кој е ангажиран да украдне истражувачки податоци за експериментални кибернетски надградувања. Низ текот на играта има 2 мини-игри кои треба да се решат правилно за да може да се продолжи со текот на играта. Исто така, има избор на крајот на играта кој дозволува на играчот да го избере текот на приказната според нивната постапка.

## 2. Упатство за играње

Играта започнува со клик на копчето "accept" во менито, по што настанува премин кон првата дијалогна сцена во играта.

![menuImage](https://github.com/user-attachments/assets/1c115a89-4761-41e5-bca4-a0c4a1accde4)

Во менито, освен копчето за започнување на играта, играчот има и две дополнителни копчиња.
- При кликање на копчето "credits", се испишуваат заслугите на сопствениците на музиката и сликите искористени, исто како и на креаторите на проектот. При повторен клик на истото копче, се тргаат од екранот.
- Копчето "music" дозволува на играчот да ја исклучи и вклучи музиката низ текот на играта при кликање на самото.
- Доколку играчот во било кој дел од играта, сака да ја исклучи, тоа може да го постигне со кликање на копчето "quit" долу десно во прозорчето на играта.

### 2.1. Дијалог сцена

Играчот може да продолжи кон наредната реченица во дијалогот со лев или десен клик на глувчето, или пак копчето SPACE на тастатурата.
Доколку играчот не сака да чека дијалогот да се испише, може да направи двоен клик со глувчето, или пак да кликне на копчето SPACE два пати, и дијалогот ќе се испише веднаш на екранот.

![dialogImage](https://github.com/user-attachments/assets/fdc53355-db90-445f-80b3-5ba9e8af3b95)


### 2.2. Отклучување на врата мини-игра

Играчот треба да ја внесе соодветната шифра дадена од страна на ликот Апок (шифрата е 0109), и за да го изврши тоа има 3 обиди. Тоа може да го изврши со кликање на копчињата на екранот, и откако ја има испишано, играчот треба да кликне на копчето ">" за да ја внесе. 

![keypadImage](https://github.com/user-attachments/assets/51c37d0a-81b2-40a8-9c86-9f53d0748b80)

Доколку играчот не ја внесе точната шифра 3 пати, играчот ја губи играта затоа што се вклучува аларм. Играчот е фатен, и тука се прикажува крајна дијалог сцена, и играта завршува.

### 2.3. Декрипција на податоци мини-игра

Играчот треба да го дешифрира зборот кој ликот Апок им го кажува (зборот е "nvfqvsuu" кога е шифриран, а играчот треба да го внесе зборот "progress"). Зборот се дешифрира користејќи ја полиазбучната шифра која стои на екранот. За помош на играчот, во десниот дел од екранот стои зборот за да можат да го гледаат додека го запишуваат. Точниот збор треба да се внесе во полето за текст (text-box), и потоа треба да се кликне на копчето десно од полето за текст со ознака ">>". Ако одоговорот е точен, на екранот се декриптира напишаниот текст, и за да продолжи кон наредната сцена играчот треба да кликне со глувчето.

![encryptedImage](https://github.com/user-attachments/assets/28ee296a-7d7c-47f8-9ee9-f56f1ab8d364)


Доколку играчот ја има внесено погрешната цифра, играта завршува затоа што се вклучува аларм. Ако играчот е фатен, се прикажува крајната дијалог сцена, и играта завршува.

### 2.4. Избор на судбина

Откако играчот ги има дешифрирано фајловите, играчот има два избори прикажани на неговиот екран во вид на копчиња.

![choiceImage](https://github.com/user-attachments/assets/3366e887-cd5e-40fa-9395-51722b1aa8f3)

Доколку играчот сака да ги разоткрие нелегалните постапки на компанијата, тој клика на левото копче, и од тука се испишува краток дијалог помеѓу нив и ликот Апок. После тоа, играта завршува, и формата автоматски се исклучува.

Ако играчот избере да застане на страната на Апок, тој клика на десното копче, и откако се испише краток дијалог помеѓу нив и ликот Апок, играта завршува.

## 3. Решение на проблемот

Во главната форма се користат објекти од класата Scene и од класата Transition. 
- Податоците кои се даваат за класата на мени сцената се потребниот дијалог од дијалог класата, label-от во кој треба да се испише дијалогот, и тајмерот за испишување на буквите.
- За Transition класата ставаме тајмерот на чиј tick се повикува преодната сцена, и label-от во кој се испишува текстот за време на транзицијата.

  ```csharp
  MenuScene = new Scene(Dialogue.Menu, lblMenu, menuTimer); //set the menu scene
  MainScene = new Scene(Dialogue.Dialogues[0], lblDialog, dialogueTimer); //set the main scene
  Credits = new Scene(Dialogue.Credits, lblDialog, creditsTimer); //set the credits dialogue
  Transition = new Transition(transitionTimer, lblCenter); //set the transition
  ```

### 3.1. Дијалог сцена

Дијалог сцената која започнува по клик на старт копчето го започнува дијалог тајмерот кој на секој tick ја повикува функцијата DisplayLine(string s).
За испишување на текстот во дијалог сцената, се користи функцијата DisplayLine(string s) која за даден string ги испишува буквите една по една додека да се испише целиот string. 

```csharp
public void DisplayLine(string s)
{
    CurrentLabel.Show();

    if (TickIndex < s.Length) //if theres a next character in the string, add to label
    {
        char c = s.ToCharArray()[TickIndex++];
        CurrentLabel.Text += c;
    }
    else // if done writing
    {
        TickIndex = 0; //reset character position for next string
        LineIndex++; //go to next line in the script
        T.Stop(); //stop the timer for the current string
    }
}
```

### 3.2. Отклучување на врата мини-игра

Копчињата се појавуваат на екранот преку функцијата SpawnAllButtons() од класата Keypad.

```csharp
public void SpawnAllButtons() //func to spawn all buttons automatically
{
    for (int i = 0; i < 12; i++)
    {
        Buttons[i] = spawnButton(ButtonText[i], Point[i]);
        Buttons[i].BringToFront();
    }
    Code.Enabled = true;
    Code.Font = new Font("Unispace", 25);
    Code.Size = new System.Drawing.Size(250, 50);
    Code.Location = new Point(90, 40);
    Code.BackColor = Color.Transparent;
    Code.ForeColor = Color.White;
    Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    Code.BorderStyle = BorderStyle.FixedSingle;

    Phantom.ActiveForm.Controls.Add(Code); //adding them to the form
}
```

### 3.3. Декрипција на податоци мини-игра

При кликнување на копчето за да се валидира дешифрираниот збор, се извршува функцијата Continue_Click(object sender, EventArgs e), која валидира дали зборот е точен, и според тоа детерминира дали играчот ќе може да продолжи со текот на приказната или пак ќе го води кон крајот на играта.

```csharp

 private void Continue_Click(object sender, EventArgs e)
 {
     if (TextBox.Text.ToLower() == "progress") //if the keyword is correct
     {
         TextBox.Enabled = false;
         DialogTimer.Start();
     }

     else //if you fail, consequences
     {
         Transition.sceneCount = 7;
         Transition.FAIL = true;
         Encrypted.Dispose();
         TransitionTimer.Start(); //starting the timer back up
     }

     Alphabet.Dispose(); //disposing of all the buttons and labels
     Cipher.Dispose();
     TextBox.Dispose();
     Continue.Dispose();
     Hint.Dispose();
 }
```

## 4. Oпис на функција

При мини-играта за декриптирање на пораката, откако ќе се внесе точната шифра, на екранот енкриптираниот текст се декриптира.
Тоа се случува со помош на следната функција, која се повикува на секој tick на тајмер.

```csharp
public bool Decrypt(string decrypted, string encrypted)
{ 
    if (TickIndex == 0)
    {
        sb.Append(encrypted); //we put the old string in the sb so we can change exact positions of the letters
    }      

    if (TickIndex < encrypted.Length)
    {
        char c = decrypted.ToCharArray()[TickIndex];
        sb[TickIndex] = c;

        CurrentLabel.Text = sb.ToString(); //replace the letter in the old string with the one in the new
        return false;
    }
    else // when done
    {
        return true;
    }
}
```

Користејќи StringBuilder, првично ја залепуваме енкриптираната порака. Потоа, користејќи ја вредноста на tick-oт ја селектираме позицијата на буквита која треба да биде заменета со таа во дешифрираната порака се додека не ја дешифрираме целата.

---
## Забелешки

Доколку формата не е во фокус низ текот на преодната сцена, формата се исклучува заради промената на непроѕирноста (opacity) која се врши на активната форма, односно кога таа е во фокус.
Ако играчот добие некој вид на нотификација од друга апликација додека ја игра, која го променува фокусот кон себе, апликацијата се исклучува (crash).

## Информации за сопствениците на користените слики и музика 

- Screenshots од играта [Cyberpunk2077](https://www.cyberpunk.net/mk/en/)
- Слики од [freepik](https://www.freepik.com/author/freepik)
- Музика од [nickpanek620](https://pixabay.com/users/nickpanek620-38266323/)
