<?php include("pageHeader.php"); ?>
<?php
$pageName = "Novo Pagador";
?>
<?php include("breadcrumb.php"); ?>


            <div class="row">
                <div class="col-12 mb-5">
                    <h1><?php echo $pageName ?></h1>                      
                </div>
            </div>
            <div class="row">
                <div class="col-12">                    
                    <!--Form-->
                    <div class="col-10 mb-5">
                        <div class="card text-white bg-dark o-hidden h-100">
                            <div class="card-header">
                                <div class="mr-5">
                                    <h4>
                                        <i class="fa fa-fw fa-money"></i>&nbsp; <?php echo $pageName ?>
                                    </h4>
                                </div>
                            </div>
                            <form>
                                <div class="card-body bg-light text-dark">
                                    <div class="row">
                                        <div class="col-md-9">
                                            <label for="nomePagador">Nome</label>
                                            <input type="text" class="form-control" name="nomePagador" id="nomePagador" placeholder="Digite o nome do pagador" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="cnpjPagador">CNPJ</label>
                                            <input type="text" class="form-control" name="cnpjPagador" id="cnpjPagador" placeholder="Digite o CNPJ do pagador" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-9">
                                            <label for="emailPagador">Email</label>
                                            <input type="email" class="form-control" name="emailPagador" id="emailPagador" placeholder="Digite o email do pagador" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="telefonePagador">Telefone</label>
                                            <input type="text" class="form-control" name="telefonePagador" id="telefonePagador" placeholder="Digite o telefone do pagador" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-9">
                                            <label for="contatoPagador">Contato</label>
                                            <input type="text" class="form-control" name="contatoPagador" id="contatoPagador" placeholder="Digite o nome do contato" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="contatoCelular">Celular</label>
                                            <input type="text" class="form-control" name="contatoCelular" id="contatoCelular" placeholder="Digite o celular do contato" />
                                        </div>
                                    </div>                                    
                                </div>
                                <div class="card-footer bg-dark pull-right">
                                    <button class="btn btn-success" type="submit">Salvar</button>
                                    <button class="btn btn-danger" type="reset">Cancelar</button>
                                </div>
                            </form>

                        </div>
                    </div>
                </div>    

            </div>
        
<?php include("pageFooter.php"); ?>
