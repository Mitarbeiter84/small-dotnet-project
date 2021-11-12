namespace SmallDotnetProject

module Say =
    let hello (name: string) : string =
        sprintf "Hello %s" name
