bool duracaoValida = TimeSpan.TryParse($"{-1}:{1}", out TimeSpan duracao);
Console.WriteLine(duracao);