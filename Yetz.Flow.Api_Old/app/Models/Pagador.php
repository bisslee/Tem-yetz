<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Pagador extends Model
{
    use HasFactory;

    protected $fillable = ['nome', 'cnpj', 'contato', 'email', 'telefone','celular', 'create_user','last_update_user'];
}
