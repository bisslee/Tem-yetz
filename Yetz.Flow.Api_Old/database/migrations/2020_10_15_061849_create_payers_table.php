<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreatePayersTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('payers', function (Blueprint $table) {
            $table->increments('id');
            $table->string('nome',150);
            $table->string('cnpj',14);
            $table->string('email',200);
            $table->string('telefone',20);
            $table->string('contato',60);
            $table->string('celular',20);
            $table->boolean('ativo');
            $table->string('user_cadastro',20);
            $table->string('user_update',20);
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('payers');
    }
}
